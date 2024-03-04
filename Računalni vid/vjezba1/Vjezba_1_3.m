originalna_slika = imread("C:\Users\nikol\Downloads\lake-8357182_1280.jpg");

povecana_siva = im2gray(imresize(originalna_slika, 2));

rotirana = imrotate(povecana_siva, 90);

whos rotirana;

imwrite(rotirana, "Slika_1_3.jpg");