import {Button} from "@/components/ui/button";
import Link from "next/link";

export default function Page() {
    return <>
        <Button>
            <Link href={"/"}>Index page</Link>
        </Button>
    </>
}
