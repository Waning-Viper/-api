import { useParams } from "react-router-dom";
import data from "./data";

function OrderDetail(){
    const { id } = useParams<{ id:string}>();
    const order = data.orders.find((o) => o._id == parseInt(id as string));

    return(
        <div>
            <h3>Order Name: {order?.user.name}</h3>
        </div>
    )
}

export default OrderDetail;