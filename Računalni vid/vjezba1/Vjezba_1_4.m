slika_iz_treceg = imread("Slika_1_3.jpg");

whos slika_iz_treceg;

% 2560x1706

% donji desni kvadrant = (1280, 853, 2560, 1706)

izrezana = imcrop(slika_iz_treceg, [1280, 853, 2560, 1706]);


subplot(2,1,1);
imshow(izrezana);
subplot(2,1,2);
imshow(slika_iz_treceg);

whos izrezana;

imwrite(izrezana, "Slika_1_4.jpg");
