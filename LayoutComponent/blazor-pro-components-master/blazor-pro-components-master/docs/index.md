---
title: ä»ç»
order: 10
sidemenu: false
hero:
  title: ProLayout
  desc: ð Use Ant Design Table like a Pro!
  actions:
    - text: å¿«éå¼å§ â
      link: /#usage
features:
  - icon: https://gw.alipayobjects.com/os/q/cms/images/k9ziitmp/13668549-b393-42a2-97c3-a6365ba87ac2_w96_h96.png
    title: ç®åæç¨
    desc: å¼ç®±å³ç¨ç Layout ç»ä»¶ï¼ä¸æ­¥å³å¯çælayout
  - icon: https://gw.alipayobjects.com/os/q/cms/images/k9ziik0f/487a2685-8f68-4c34-824f-e34c171d0dfd_w96_h96.png
    title: Ant Design
    desc: ä¸ Ant Design è®¾è®¡ä½ç³»ä¸èç¸æ¿ï¼æ ç¼å¯¹æ¥ antd é¡¹ç®ï¼å¼å®¹ antd 3.x & 4.x
  - icon: https://gw.alipayobjects.com/os/q/cms/images/k9ziip85/89434dcf-5f1d-4362-9ce0-ab8012a85924_w96_h96.png
    title: å½éå
    desc: æä¾å®å¤çå½éåè¯­è¨æ¯æï¼ä¸ Ant Design ä½ç³»æé
  - icon: https://gw.alipayobjects.com/mdn/rms_05efff/afts/img/A*-3XMTrwP85wAAAAAAAAAAABkARQnAQ
    title: é¢è®¾æ ·å¼
    desc: æ ·å¼é£æ ¼ä¸ antd ä¸èç¸æ¿ï¼æ éé­æ¹ï¼æµç¶å¤©æ
  - icon: https://gw.alipayobjects.com/os/q/cms/images/k9ziieuq/decadf3f-b53a-4c48-83f3-a2faaccf9ff7_w96_h96.png
    title: é¢è®¾è¡ä¸º
    desc: è·¯ç±å¯ä»¥é»è®¤ççæèååé¢åå±, å¹¶ä¸èªå¨æ´æ°æµè§å¨ç title
  - icon: https://gw.alipayobjects.com/os/q/cms/images/k9zij2bh/67f75d56-0d62-47d6-a8a5-dbd0cb79a401_w96_h96.png
    title: Typescript
    desc: ä½¿ç¨ TypeScript å¼åï¼æä¾å®æ´çç±»åå®ä¹æä»¶

footer: Open-source MIT Licensed | Copyright Â© 2017-present
---

## ä½¿ç¨

```bash
npm i @ant-design/pro-layout --save
// or
yarn add @ant-design/pro-layout
```

```jsx | pure
import BasicLayout from '@ant-design/pro-layout';

render(<BasicLayout />, document.getElementById('root'));
```

## ç¤ºä¾

[site](https://ant-design.github.io/ant-design-pro-layout/)

# åºæ¬ä½¿ç¨

ProLayout ä¸ umi éåä½¿ç¨ä¼ææå¥½çææï¼umi ä¼æ config.ts ä¸­çè·¯ç±å¸®æä»¬èªå¨æ³¨å¥å°éç½®ç layout ä¸­ï¼è¿æ ·æä»¬å°±å¯ä»¥åå»æåèåçç¦æ¼ã

ProLayout æ©å±äº umi ç router éç½®ï¼æ°å¢äº nameï¼iconï¼locale,hideInMenu,hideChildrenInMenu ç­éç½®ï¼è¿æ ·å¯ä»¥æ´æ¹ä¾¿ççæèåï¼å¨ä¸ä¸ªå°æ¹éç½®å³å¯ãæ°æ®æ ¼å¼å¦ä¸ï¼

```ts | pure
export interface MenuDataItem {
  hideChildrenInMenu?: boolean;
  hideInMenu?: boolean;
  icon?: string;
  locale?: string;
  name?: string;
  path: string;
  [key: string]: any;
}
```

ProLayout ä¼æ ¹æ® `location.pathname` æ¥èªå¨éä¸­èåï¼å¹¶ä¸èªå¨çæç¸åºçé¢åå±ãå¦æä¸æ³ä½¿ç¨å¯ä»¥èªå·±éç½® `selectedKeys` å `openKeys` æ¥è¿è¡åæ§éç½®ã

## Demo

<code src="./demo/base.tsx" />
