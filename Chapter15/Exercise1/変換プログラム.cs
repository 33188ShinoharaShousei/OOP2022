// バイト配列をImageオブジェクトに変換
public static Image ByteArrayToImage(byte[] b) {
    ImageConverter imgconv = new ImageConverter();
    Image img = (Image)imgconv.ConvertFrom(b);
    return img;
}

// Imageオブジェクトをバイト配列に変換
public static byte[] ImageToByteArray(Image img) {
    ImageConverter imgconv = new ImageConverter();
    byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
    return b;
}
