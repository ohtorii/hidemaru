# 秀丸エディタの辞書ファイル

辞書一覧

- [MEL Script(Autodesk MAYA 2019)](#mel-scriptautodesk-maya-2019)
- [HLSL](#hlsl)
- [のどか](#のどか)
- [CMake](#cmake)
- [Makefile](#makefile)
- [bat](#bat)
- [c++](#c)
- [Graphviz](#graphviz)
- [protocol buffers](#protocol-buffers)
- [ダウンロード](#ダウンロード)
- [連絡先](#連絡先)
- [寄付](#寄付)


# MEL Script(Autodesk MAYA 2019)

MAYA MEL Scriptの辞書ファイルです。

## 補足

MELコマンド一覧は以下の一行スクリプトで得ています。（約5000個の単語をリストアップしています）

	help -l "*";

## ファイル

[oh_maya_mel.txt](files/oh_maya_mel.txt)

# HLSL

HLSL(High Level Shading Language)の辞書ファイルです。

約900個の単語が含まれています。MAYAとSoftimage XSI特有の単語も登録しています。

## 設定方法
![HLSL設定](images/hlsl.png "HLSL設定")

## ファイル

[oh_hlsl.txt](files/oh_hlsl.txt)

## 謝辞
- [hlsl.vim](https://github.com/beyondmarc/hlsl.vim)

かなり参考にしました、感謝😘

# のどか

[汎用キーバインディング変更ソフト「のどか」](https://appletllc.com/web/nodoka.htm)の辞書ファイルです。

## 辞書に含まれる内容

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

[oh_nodoka.txt](files/oh_nodoka.txt)

# CMake

[CMake](https://cmake.org/)（ビルド自動化のためのフリーソフトウェア）の辞書ファイルです。

約1300個の単語が登録されています。

## 設定方法
![cmake設定](images/cmake.png "cmake設定")

## ファイル

[oh_cmake.txt](files/oh_cmake.txt)


## 謝辞
- [cmake.vim : CMake syntax highlighting ](https://www.vim.org/scripts/script.php?script_id=600)
- [CMake plugin for IntelliJ Idea CE and Android Studio](https://github.com/ArtsiomCh/CMake)

かなり参考にしました、感謝😘


# Makefile

Makefileの辞書ファイルです。

## 辞書に含む内容

- 関数
- 自動変数
- 条件分岐
- define
- gnu make特有の変数
- 暗黙ルールで使われている変数
- 追加の引数
- 特別なビルトイン・ターゲット名

## 設定方法

makefileで頻繁に利用する以下文字を候補に挙げるため、

	$@
	$%
	$<
	$(CXXFLAGS)
	$(CFLAGS)
	  :
	  :

単語補完を書き画像のように設定してください。

|設定名|文字列|
|:--:|:--:|
|単語先頭の文字|$.-({|
|単語途中の文字|({|
|単語終了文字|)}|

![makefile設定](images/makefile.png "makefile設定")


## ファイル

[oh_makefile.txt](files/oh_makefile.txt)



# bat

Windowsバッチファイルの辞書です。

## 辞書に含まれる内容

|項目|内容|
|:--:|:--:|
|コマンド|if,md,enabledelayedexpansion,...,IF,MD,ENABLEDELAYEDEXPANSION,...|
|利用頻度が高い環境変数|homedrive,temp,...,HOMEDRIVE,TEMP,...|

大文字版と小文字版の単語を登録しました。


## 単語補完の検索対象の詳細

![bat設定](images/bat.png "画像タイトル")

## ファイル

[oh_bat.txt](files/oh_bat.txt)



# c++

c++の辞書ファイルです。

C/C++標準ライブラリ、STL、VisualStudioなどから約4000個の単語を登録しています。


## 辞書に含まれる内容

|バージョン|対応状況|
|--|--|
|C++11|○|
|C++14|○|
|C++17|×|
|C++20|×|
|C++23|×|

各バージョンの単語をできるだけ登録したつもりですが抜けは色々あると思います😅

C++警察の皆様におかれましては静観していただきますとありがたいです。

## ファイル

[oh_cpp.txt](files/oh_cpp.txt)

## 謝辞
- [https://github.com/octol/vim-cpp-enhanced-highlight](https://github.com/octol/vim-cpp-enhanced-highlight)
- [http://www.vim.org/scripts/script.php?script_id=4293](http://www.vim.org/scripts/script.php?script_id=4293)
- [http://www.vim.org/scripts/script.php?script_id=2224](http://www.vim.org/scripts/script.php?script_id=2224)
- [http://www.vim.org/scripts/script.php?script_id=1640](http://www.vim.org/scripts/script.php?script_id=1640)
- [http://www.vim.org/scripts/script.php?script_id=3064](http://www.vim.org/scripts/script.php?script_id=3064)

# Graphviz

[Graphviz](http://graphviz.org/)（Dot言語で記述されたグラフ構造を画像ファイルへ出力するツール）の辞書ファイルです。

約1400個の単語を登録しました。

## 設定方法

![Graphviz設定](images/graphviz_dic.png "Graphviz設定")

## ファイル

[oh_dot.txt](files/oh_dot.txt)


#  protocol buffers

[protocol buffers](https://developers.google.com/protocol-buffers)(Googleが開発したシリアライズフォーマット)の辞書ファイルです。

## 辞書に含む内容

- 真偽値
- extend
- field option
- file option
- repeat
- rpc
- service
- structure
- syntax
- type map
- type
- enum


## 設定方法
![protobuf設定](images/proto.png "protobuf設定")

## ファイル

[oh_proto.txt](files/oh_proto.txt)



# ダウンロード

[filesフォルダ](files)から必要なファイルをダウンロードしてください。


# 連絡先

- <https://ohtorii.hatenadiary.jp>
- <https://twitter.com/ohtorii>
- <https://github.com/ohtorii>

# 寄付

もし気に入ってくれたらSteamからゲームを寄付してくれるとうれしいです😘
- https://store.steampowered.com/wishlist/id/ohtorii

開発の励みになります。
