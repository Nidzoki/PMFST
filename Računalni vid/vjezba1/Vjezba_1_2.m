siva_slika = im2gray(imread("C:\Users\nikol\Downloads\lake-8357182_1280.jpg"));

smanjena = imresize(siva_slika, 0.5); 

whos smanjena;

imwrite(smanjena, "Slika_1_2.jpg");