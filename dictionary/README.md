# 秀丸エディタの辞書ファイル

- [秀丸エディタの辞書ファイル](#秀丸エディタの辞書ファイル)
- [MEL Script(Autodesk MAYA 2019)の辞書ファイル](#mel-scriptautodesk-maya-2019の辞書ファイル)
- [のどかの辞書ファイル](#のどかの辞書ファイル)
- [CMake](#cmake)
- [ダウンロード](#ダウンロード)
- [連絡先](#連絡先)


# MEL Script(Autodesk MAYA 2019)の辞書ファイル

MAYA MEL Scriptの辞書ファイルです。

## 補足

MELコマンド一覧は以下の一行スクリプトで得ています。（約5000個の単語をリストアップしています）

	help -l "*";

## ファイル

[maya_mel.txt](files/maya_mel.txt)


# のどかの辞書ファイル

[汎用キーバインディング変更ソフト「のどか」](https://appletllc.com/web/nodoka.htm)の辞書ファイルです。

辞書に含まれる内容

|項目|内容|
|:--:|:--:|
|真偽値|enable,disable,...|
|命令|key,keymap,...|
|オプション|ats4nodoka,before-key-down...|
|Function|&CancelPrefix,&ClipboardCopy,...|

## 単語補完の検索対象の詳細

以下キーワードを候補に挙げるため、

- &CancelPrefix, ...
- before-key-down, ...

単語補完を下記画像のように設定してください。

![nodoka設定](images/nodoka_1.png "nodoka設定")

## ファイル

[nodoka.txt](files/nodoka.txt)

# CMake

[CMake](https://cmake.org/)（ビルド自動化のためのフリーソフトウェア）の辞書ファイルです。

約1300個の単語が登録されています。

## 設定方法
![cmake設定](images/cmake.png "cmake設定")

## ファイル

[cmake.txt](files/cmake.txt)


## 謝辞
- [cmake.vim : CMake syntax highlighting ](https://www.vim.org/scripts/script.php?script_id=600)
- [CMake plugin for IntelliJ Idea CE and Android Studio](https://github.com/ArtsiomCh/CMake)

かなり参考にしました、感謝😘

# ダウンロード

[filesフォルダ](files)から必要なファイルをダウンロードしてください。


# 連絡先

<https://ohtorii.hatenadiary.jp>

<https://twitter.com/ohtorii>

<https://github.com/ohtorii>
