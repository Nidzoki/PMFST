slika = imread("C:\Users\nikol\Downloads\zoo-8378189_640.jpg");

siva = rgb2gray(slika);

hsv_slika = rgb2hsv(slika);

[H, S, V] = imsplit(hsv_slika);

montage({H, S, V}, 'Size',[1 3]);

imwrite(siva, "Slika_2_siva.jpg");

imwrite(H, "Slika_2_H.jpg");
imwrite(S, "Slika_2_S.jpg");
imwrite(V, "Slika_2_V.jpg");