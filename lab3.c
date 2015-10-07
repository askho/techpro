#include <stdio.h>
#include <unistd.h>
#include <pthread.h>

int stop = 0;

void* counter(void* tabPtr) {
    int num = 0;
    int tab = (int)tabPtr;
    while(stop != 1) {
        printf("%d\n",num++);
    }
    printf("\n%d", tab);
    pthread_exit(0);
}

int main() {
    pthread_t thread1, thread2;
    pthread_create(&thread1,NULL, counter, (void*)2);
    sleep(5);
    stop = 1;
    pthread_join(thread1, NULL);
}
