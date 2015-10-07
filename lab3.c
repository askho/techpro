#include <stdio.h>
#include <unistd.h>
#include <pthread.h>
#include <string.h>
#include <semaphore.h>
#include <fcntl.h>
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

int main() {
    pthread_t thread1, thread2, thread3, thread4;
    printLock = sem_open("sem", O_CREAT, 0777, 1);
    pthread_create(&thread1,NULL, counter, (void*)0);
    pthread_create(&thread2,NULL, counter, (void*)1);
    pthread_create(&thread3,NULL, counter, (void*)2);
    pthread_create(&thread4,NULL, counter, (void*)3);
    sleep(1);
    stop = 1;
    pthread_join(thread1, NULL);
    pthread_join(thread2, NULL);
    pthread_join(thread3, NULL);
    pthread_join(thread4, NULL);
}
