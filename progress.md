OSTEP

4 The Abstraction: The Process
Prosesi running program diye ifade edip OS'in user'a sunduğu bir abstraction olarak ifade ediyor.
Program bir dosyada yatan kod satırları. Sonsuza dek orda duracak. Çalıştırılmayı bekliyor. Programı kullanılır bir objeye dönüştüren şey OS. Onu alıp çalıştırıyor.

4.3 Process Creation
Programın kendisini belleğe yüklemek (address space) ayrı, çalışması için gereken bellek alanını ayırmak ayrı bir iş.
Run-time stack (ya da stack) lokal değişkenler ve fonksiyon parametreleri için gerekliyken, heap dinamik olarak ayrılan bir bellek alanı. Ayrıca file I/O ile ilgili initialization yapmak da OS'in sorumluluğu.
