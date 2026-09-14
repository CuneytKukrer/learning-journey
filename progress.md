OSTEP

4 The Abstraction: The Process
Prosesi running program diye ifade edip OS'in user'a sunduğu bir abstraction olarak ifade ediyor.
Program bir dosyada yatan kod satırları. Sonsuza dek orda duracak. Çalıştırılmayı bekliyor. Programı kullanılır bir objeye dönüştüren şey OS. Onu alıp çalıştırıyor.

4.3 Process Creation
Programın kendisini belleğe yüklemek (address space) ayrı, çalışması için gereken bellek alanını ayırmak ayrı bir iş.
Run-time stack (ya da stack) lokal değişkenler ve fonksiyon parametreleri için gerekliyken, heap dinamik olarak ayrılan bir bellek alanı. Ayrıca file I/O ile ilgili initialization yapmak da OS'in sorumluluğu.

CSAPP - 14 Eylül
Kendi UNIX shell'imizi yazmayı öğrenicez. Kendi Web Server'ımızı.
Porgramın source kodundaki #include kelimesini düşünelim. Herbir karakter 8 bit yani 1 byte ile temsil ediliyor. # karakteri 1 byte ve ASCII tablosundaki integer karşılığı 35. Aynı şekilde source code'daki her bir karakterin bir ASCII karşılığı var. Bunun gibi yalnızca ASCII karakterlerinden oluşan dosyalara text dosyası diyoruz. Dosya uzantısı önemli değil. Mesela bu dosya hello.c olarak kaydedildi. Diğer bütün dosyalar binary dosya olarak bilinir.

Compilation 4 adımdan oluşur. 
Preprocessing Phase
hello.c programını Pre-processor alıp içindeki # ile başlayan directive'leri tarar. #include<stdio.h> ile karşılaştığında stdio.h header dosyasının içeriğini alıp hello.c dosyasının içine yazar. Bundan sonra hello.i uzantılı bir dosya oluşur.
Compilation Phase
Ardından Compiler hello.i dosyasını alıp assembly-language programına dönüştürür, dosya uzantısı hello.s olur. Dosya içeriği suq movl gibi low level machine language instruction'larının text formundan oluşur. Assembly language kullanışlıdır çünkü high level dillerin compiler'larına aynı output language'i vermiş olur. C ve Fortran compilerları bu sayede aynı çıktıyı verir.
Assembly Phase
assembler hello.s'i machine-language instructionlara dönüştürüp hello.o dosyasını oluşturur, relocatable object program olur.
Bu dosya bu akışta oluşan ilk binary dosyadır.
Linking Phase
hello programımızın içinden printf çağrılıyor. Standard C Library'nin içinde olan bir function. printf.o adında ayrı bir precompiled object file içindedir (printf.o). Bunun hello.o ile merge edilmesi gerekir. Linker bunu halleder. Sonuç hello dosyasıdır. Bu bir executable object file'dır. Belleğe yüklenmeye hazır ve sistem tarafından execute edilmeye de hazırdır.
