# ShipShooting 🚀

**ShipShooting** là game bắn tàu không gian 2D được phát triển bằng **Unity 2022.3 LTS**.  
Người chơi điều khiển tàu vũ trụ, bắn thiên thạch và thu thập vật phẩm để sử dụng kỹ năng.

---

# Gameplay
- Điều khiển tàu theo vị trí chuột.
- Giữ chuột trái để bắn đạn.
- Né và tiêu diệt junk / asteroid xuất hiện ngẫu nhiên.
- Thu thập item và sử dụng kỹ năng qua hotkey.
- Quản lý item thông qua hệ thống inventory.

---

# Công nghệ sử dụng
- **Engine:** Unity `2022.3.12f1`
- **Ngôn ngữ:** C#
- **IDE:** Visual Studio

---

# Cấu trúc thư mục chính
```
Assets
 ├── Data            # Logic gameplay (ship, item, UI, spawner...)
 ├── _Scenes         # Scene menu và gameplay
 ├── Prefabs         # Prefab game object
 └── Scripts         # Script chính của game
```

---

# Chạy project

## Yêu cầu
- Cài **Unity Hub**
- Cài **Unity Editor 2022.3.12f1**

## Các bước chạy
1. Clone repository

```bash
git clone <URL_REPO>
cd ShipShooting
```

2. Mở **Unity Hub**

3. Chọn **Open Project** → chọn thư mục `ShipShooting`

4. Mở scene gameplay

```
Assets/_Scenes/GalaxyDemo.unity
```

5. Nhấn **Play** để chạy game.

---

# Điều khiển

| Phím | Chức năng |
|-----|-----------|
| Chuột | Di chuyển tàu |
| Chuột trái | Bắn đạn |
| 1 → 7 | Sử dụng kỹ năng |
| UI Button | Mở / đóng Inventory |

---

# Hệ thống chính trong code

- **InputManager**  
  Quản lý input chuột và bàn phím.

- **ShipFollowMouse**  
  Điều khiển tàu bay theo vị trí chuột.

- **ShipShootingByMouse**  
  Xử lý bắn đạn khi giữ chuột trái.

- **GameCtrl**  
  Quản lý trạng thái game và camera.

- **UIInventory / UIHotKeyCtrl**  
  Hệ thống inventory và hotkey skill.

- **Spawner / Junk / Damage**  
  Spawn enemy → va chạm → nhận sát thương.

---

# Hướng phát triển thêm
- Hệ thống **Level / EXP** cho ship.
- Thêm **enemy và weapon mới**.
- **Save inventory** bằng JSON.
- Tối ưu **Object Pooling** cho bullet và effect.

---

# Tác giả
**An**  
Unity Developer (Intern)
