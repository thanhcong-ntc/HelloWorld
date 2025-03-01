document.addEventListener("DOMContentLoaded", function() {
    const music = document.getElementById("background-music");
    const musicButton = document.getElementById("music-button");

    function playMusic() {
        music.muted = false;
        music.play().catch(() => {
            console.log("Trình duyệt chặn autoplay, yêu cầu người dùng tương tác.");
            musicButton.style.display = "block"; // Hiện nút nếu bị chặn
        });
    }

    // Tự động phát nhạc khi trang load
    playMusic();

    // Khi người dùng bấm nút, bật/tắt nhạc
    musicButton.addEventListener("click", function() {
        if (music.paused) {
            music.play();
            musicButton.textContent = "🔇 Pause Music";
        } else {
            music.pause();
            musicButton.textContent = "🔊 Play Music";
        }
    });
});
