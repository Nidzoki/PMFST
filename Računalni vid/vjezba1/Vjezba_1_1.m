slika = imread("C:\Users\nikol\Downloads\lake-8357182_1280.jpg");
siva_slika = im2gray(slika);
whos siva_slika;
imwrite(siva_slika, "Slika_1_1.jpg");
