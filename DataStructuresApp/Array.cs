using System;

namespace DataStructuresApp {
    public class MyArray {
        int [] numbers;
        private int count = 0;

        public MyArray(int length) {
            numbers = new int[length];
        }

        public void insert(int item) {
            if (numbers.Length <= count) {
                int[] newArray = new int[numbers.Length * 2];
              
                for(int i = 0; i < count; i++){
                    newArray[i] = numbers[i];
                }
                numbers = newArray;
            }
            numbers[count] = item; 
            count++;
        }

        public void removeAt(int index) {
            if (index < 0 || index >= count) {
                throw new ArgumentException("index is out of range");
            }
            for(int i = index; i < count - 1; i++) {
                numbers[i] = numbers[i + 1];
            }
            count--;
        }

        public int indexOf(int value) {

            for(int i = 0; i < count; i++) {
                if ( numbers[i] == value ) {
                    return i;
                }
            }
            return -1;
        }

        public int max() {
            int max = numbers[0];
            for (int i = 0; i < count; i++) {
                if (numbers[i]  > max) 
                    max = numbers[i];
            }
            return max;
        }

        public MyArray intersect(MyArray numbers2) {
            MyArray result = new MyArray(count);
            for (int i = 0; i < count; i++) {
                if (numbers2.indexOf(numbers[i]) != -1 && result.indexOf(numbers[i]) == -1)
                    result.insert(numbers[i]);
            }
            return result;
        }

        public MyArray reverse() {
            MyArray result = new MyArray(count);
            for (int i = count - 1; i >= 0; i--) {
                result.insert(numbers[i]);
            }
            return result;
        }

        public void insertAt(int number, int index){
            if (index < 0 || index > count) {
                throw new ArgumentException("Index out of range.");
            }

            if (numbers.Length <= count) {
                int[] newArray = new int[numbers.Length * 2]; 
                for(int i = 0; i < count; i++)
                    newArray[i] = numbers[i];
                numbers = newArray;
            }

            for(int i = count; i > index; i--)
                numbers[i] = numbers[i - 1];
            numbers[index] = number;
            count++;
        }

        public void print() {
            for(int i = 0; i < count; i++) {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}