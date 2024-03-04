slika = imread("C:\Users\nikol\Downloads\zoo-8378189_640.jpg");

siva = rgb2gray(slika);

hsv_slika = rgb2hsv(slika);

[H, S, V] = imsplit(hsv_slika);

kontrast = histeq(siva);

subplot(1,4,1);
imhist(siva);

subplot(1,4,2);
imshow(siva);

subplot(1,4,3);
imshow(kontrast);

subplot(1,4,4);
imhist(kontrast);

imwrite(siva, "Slika_2_2_1.jpg");
imwrite(kontrast, "Slika_2_2_2.jpg");