# Unity Package Managerの練習リポジトリ

カスタムパッケージの作成と公開、利用方法を確認するための簡単なプロジェクトです。

## 開発環境
- Unity2021.3.10f1

## 試すこと
- 一つのリポジトリにあるフォルダーで複数のパッケージを公開
- gitの依存関係

## プロジェクト構成
- AM1PracticeCommon(AM1.PracticeCommon)
  - 共有ライブラリ用のパッケージ
  - 他から参照される
- AM1PackageA(AM1.PackageA)
  - 一つ目のパッケージ
  - AM1PracticeCommonへ依存
- AM1PackageB(AM1.PackageB)
  - 二つ目のパッケージ
  - AM1PracticeCommonへ依存

## チェック方法

1. 新規プロジェクトを作成して、Package Managerで以下の2つのgitリポジトリーを登録します
  - `https://github.com/am1tanaka/UnityPackagePractice.git?path=/Assets/AM1PackageA`
  - `https://github.com/am1tanaka/UnityPackagePractice.git?path=/Assets/AM1PackageB`
1. シーンに空のゲームオブジェクトを作成します
1. 作成した空のゲームオブジェクトに以下のスクリプトをアタッチします
  - `DrawLabel`
  - `PracticeA`
  - `PracticeB`

以上でPlayして、画面に「Package A <フレーム数>」と「Package B <フレーム数>」が表示されれば正常に動作しています。


## ライセンス
[MIT License](./LICENSE.md)

Copyright (c) 2022 Yu Tanaka

## 参考・関連URL
- [Unityマニュアル. カスタムパッケージの作成](https://docs.unity3d.com/ja/2021.3/Manual/CustomPackages.html)
- [Unityマニュアル. Gitの依存関係](https://docs.unity3d.com/ja/2021.3/Manual/upm-git.html)
- [Unityマニュアル. パッケージマニフェスト](https://docs.unity3d.com/ja/2021.3/Manual/upm-manifestPkg.html)
