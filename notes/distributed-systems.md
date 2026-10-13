İki servis arasında http ile iletişimde Http time-out olursa, çağrılan service (server) time-out'tan haberi olmadan çalışmaya devam eder. Çünkü http time-out client side'tır.
#### Mülakatta Bu Detayı Nasıl Kullanırsın?
Bu, çok üst seviye bir cevap. Şöyle söyle:  
"HTTP timeout is a client-side concept. When the order service times out, the payment service has no idea — it continues processing because HTTP over TCP doesn't propagate cancellation by default. So a payment can be successfully committed even though the caller saw a timeout. This is why I never treat timeout as 'failed' — I treat it as 'unknown' and reconcile later. I also never use RequestAborted to cancel a payment mid-flight, because the payment provider might have already processed it. The rule is: never cancel a non-idempotent write after it has started."  
Bu cevap, sana distributed systems, idempotency, at-least-once semantics, cancellation semantics konularında olgunluk kazandırır.
