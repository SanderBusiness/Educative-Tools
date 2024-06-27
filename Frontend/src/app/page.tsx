import {Button} from "@/components/ui/button";
import Link from "next/link";

export default function Page({ params }: { params: { slug: string } }) {
  return <Button>
    <Link href={"/Test"}>Test page</Link>
  </Button>
}
