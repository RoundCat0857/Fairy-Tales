## 御伽奏子
### 環境
  Unity 3.5.1f

### プロジェクトの開始

1. `git clone`
2. Unityでクローンしたディレクトリを開く
手順Open→フォルダ選択

### フォルダ構成
- Assets以下に関して
  - Package
    Assets Store から落とした Assets を入れておきます
  - Project
    - Audio  
      音楽周りを入れます
    - Design  
      デザイン周りを入れます
    - Program  
      基本的に`Program/<SceneName>/`に各シーン毎に使用するMaterials, Scripts, Prefab などを管理します  
      なのでシーンは`Program/<SceneName>/SceneName.unity`に置き、`Program/<Scene Name>/Materials`や`Program/<Scene Name>/Scripts`内のファイルを編集することになります

  構造がわかりやすくなるようにdummyファイルを足してあります。中身ができたら要らないDummyファイルは各自消してからpushしてください。
