import type { Metadata } from "next";
import "./globals.css";
import React from "react";
import {
    Menubar,
    MenubarContent,
    MenubarItem,
    MenubarMenu, MenubarSeparator,
    MenubarShortcut,
    MenubarTrigger
} from "@/components/ui/menubar";
import Link from "next/link";

export const metadata: Metadata = {
  title: "Educative Tools",
  description: "An open-source project with handy tools for teachers & students",
};

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="en" suppressHydrationWarning>
      <body suppressHydrationWarning>
          <Menubar>
              <MenubarMenu>
                  <MenubarTrigger>
                      <Link href={"/"}>
                          <b>Educative Tools</b>
                      </Link>
                  </MenubarTrigger>
              </MenubarMenu>
              <MenubarMenu>
                  <MenubarTrigger>
                      <Link href={"/Quiz"}>Quiz</Link>
                  </MenubarTrigger>
              </MenubarMenu>
          </Menubar>
        {children}
      </body>
    </html>
  );
}
