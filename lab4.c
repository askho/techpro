#include <stdio.h>
#include <pthread.h>
#include <unistd.h>
#include <semaphore.h>
void* consumer();
void* producer();
sem_t *bufferAvailableToRead, *bufferAvailableToWrite;
int buffer[10];
int writtenTo = 0;
int readTo = 0;
int main(int argc, char **argv) {
  sem_close(bufferAvailableToRead);
  sem_unlink("bufferAvailableToRead");
  sem_close(bufferAvailableToWrite);
  sem_unlink("bufferAvailableToWrite");
  bufferAvailableToRead = sem_open("bufferAvailableToRead", O_CREAT, 0777, 0);
  bufferAvailableToWrite = sem_open("bufferAvailableToWrite", O_CREAT, 0777, 10);
  pthread_t consumerThread, producerThread;
  pthread_create(&consumerThread, NULL, consumer, NULL);
  pthread_create(&producerThread, NULL, producer, NULL);

  pthread_join(consumerThread, NULL);
  pthread_join(producerThread, NULL);
  return 0;
}

void* consumer() {
  while(1){
    sem_wait(bufferAvailableToRead);
      printf("Consumer read %d \n", buffer[readTo]);
      buffer[readTo++] = 0;
      if(readTo == 10) {
        readTo = 0;
      }
    sem_post(bufferAvailableToWrite);
    sleep(2);
  }

  return NULL;
}

void* producer() {
  int index;
  while(1){
    sem_wait(bufferAvailableToWrite);
      printf("Producer wrote %d \n", index);
      buffer[writtenTo++] = index++;
      if(writtenTo == 10) {
        writtenTo = 0;
      }
    sem_post(bufferAvailableToRead);

    sleep(1);
  }

  return NULL;
}
