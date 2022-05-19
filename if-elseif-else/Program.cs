/* 
1. 네 개의 요소를 포함하는 실수의 새 배열을 선언하시오.
2. 배열의 요소에 값을 할당하시오.
3. 문자열 보간을 사용하여 배열의 값을 검색하시오.
4. 배열의 첫 번째 요소 값을 다시 할당한 후 출력하시오.

1. 배열의 선언과 초기화를 동시에 하시오.
2. Length속성을 사용해 배열의 크기를 가져오시오.
*/

// float[] point = new float[5];

// point[0] = 23.3f;
// point[1] = 23.4f;
// point[2] = 23.5f;
// point[3] = 23.6f;
// point[4] = 23.9f;

float[] point = {4.5f, 6.73f, 92.4f, 92.1f, 890.2f};

Console.WriteLine($"{point[0]}\t\t{point[1]}\t{point[2]}\t{point[3]}\t{point[4]}");
Console.WriteLine($"{point.Length}");