Random random = new Random();
int daysUntilExpiration = random.Next(12); // 0 ~ 11까지  총 12일
int discountPercentage = 0;
bool expiration = true;

daysUntilExpiration = 0; 
//expiration = false; 

if ((daysUntilExpiration >= 6) && (daysUntilExpiration <= 10)) {
    if (expiration) Console.WriteLine("Your subscription will expire soon. Renew now!");
    else Console.WriteLine("사용자의 구독이 10일 이내에 만료되지 않는 경우 아무것도 표시하지 않습니다.");
}

else if ((daysUntilExpiration >= 2) && (daysUntilExpiration <= 5) && (expiration)) {
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration}days."); 
    Console.WriteLine($"Renew now and save {discountPercentage}%");
}

else if (daysUntilExpiration == 1) {
    discountPercentage = 20;
    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine($"Renew now and save {daysUntilExpiration}%!");        
}

else if (daysUntilExpiration < 1) Console.WriteLine("Your subscription has expired.");