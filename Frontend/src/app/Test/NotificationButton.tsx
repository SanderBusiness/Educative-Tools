'use client'

import {toast} from "sonner";
import { Toaster } from "@/components/ui/sonner"
import {Button} from "@/components/ui/button";

export default function NotificationButton() {
    function handleClick() {
        toast("Check out!", {
            description: "This is a description",
            action: {
                label: "Close",
                onClick: () => console.log("Close Clicked")
            }
        })
    }

    return <>
        <Toaster />
        <Button onClick={handleClick}>
            Notify
        </Button>
    </>
}
