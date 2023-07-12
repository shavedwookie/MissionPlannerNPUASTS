
using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.UInt32;
using uint64_t = System.UInt64;

using int8_t = System.SByte;
using int16_t = System.Int16;
using int32_t = System.Int32;
using int64_t = System.Int64;

using float32 = System.Single;

using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace DroneCAN
{
    public partial class DroneCAN {
        static void encode_com_hobbywing_esc_SetAngle_req(com_hobbywing_esc_SetAngle_req msg, dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx, bool fdcan) {
            uint8_t[] buffer = new uint8_t[8];
            _encode_com_hobbywing_esc_SetAngle_req(buffer, msg, chunk_cb, ctx, !fdcan);
        }

        static uint32_t decode_com_hobbywing_esc_SetAngle_req(CanardRxTransfer transfer, com_hobbywing_esc_SetAngle_req msg, bool fdcan) {
            uint32_t bit_ofs = 0;
            _decode_com_hobbywing_esc_SetAngle_req(transfer, ref bit_ofs, msg, !fdcan);
            return (bit_ofs+7)/8;
        }

        static void _encode_com_hobbywing_esc_SetAngle_req(uint8_t[] buffer, com_hobbywing_esc_SetAngle_req msg, dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx, bool tao) {
            memset(buffer,0,8);
            canardEncodeScalar(buffer, 0, 8, msg.option);
            chunk_cb(buffer, 8, ctx);
            memset(buffer,0,8);
            canardEncodeScalar(buffer, 0, 16, msg.angle);
            chunk_cb(buffer, 16, ctx);
        }

        static void _decode_com_hobbywing_esc_SetAngle_req(CanardRxTransfer transfer,ref uint32_t bit_ofs, com_hobbywing_esc_SetAngle_req msg, bool tao) {

            canardDecodeScalar(transfer, bit_ofs, 8, false, ref msg.option);
            bit_ofs += 8;

            canardDecodeScalar(transfer, bit_ofs, 16, false, ref msg.angle);
            bit_ofs += 16;

        }
    }
}