int[] inventory = { 42, 23, 18, 34};
int sum = 0;
int bin = 0;

foreach (int items in inventory) {
    sum += items;
    bin ++;
    Console.WriteLine($"{bin}번 보관함의 완제품 수 : {items} (누계 : {sum})");
}