#include <stdio.h>
#include <unistd.h>
#include <pthread.h>
#include <string.h>
#include <semaphore.h>
#include <fcntl.h>
#include <stdlib.h>
void printUsage();

int stop = 0;
sem_t *printLock;
void* counter(void* tabPtr) {
    int num = 0;
    int tab = (int)tabPtr;
    while(stop != 1) {
        sem_wait(printLock);
        for(int i =0; i < tab; i++) {
            printf("\t");
        }
        printf("%d\n", num++);
        sem_post(printLock);
    }
    
    pthread_exit(0);
}
void * time(void * timeLimit) {
    sleep((int)timeLimit);
    stop = 1;
    pthread_exit(0);
}

int main ( int argc, char **argv ) {
    /**
        Handle arguments.
     **/
    if(argc != 3 || strcmp(argv[1], "-h") == 0) {
        printUsage();
        return 1;
    }
    int threadNum = atoi(argv[1]);
    int sleepTime = atoi(argv[2]);
    if(threadNum > 6) {
        threadNum = 6;
    }
    sem_close(printLock);
    sem_unlink("sem");
    
    pthread_t thread[7];
    printLock = sem_open("sem", O_CREAT, 0777, 1);
    pthread_create(&thread[0],NULL, counter, (void*)sleepTime); /*Create timer thread*/
    for(int i = 1; i < threadNum ; i++) {
        pthread_create(&thread[i],NULL, counter, (void*)i);
    }
    
    for(int i = 0; i < threadNum ; i++) {
        pthread_join(thread[i], NULL);
    }
    
    sem_close(printLock);
    sem_unlink("sem");

}

void printUsage() {
    printf("Usage:\n");
    printf("Param1 : integer for number of threads (Max6)\n");
    printf("Param2 : integer for time to run\n");
}