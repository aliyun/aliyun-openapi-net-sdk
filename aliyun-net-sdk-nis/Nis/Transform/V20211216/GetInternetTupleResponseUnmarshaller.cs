/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.nis.Model.V20211216;

namespace Aliyun.Acs.nis.Transform.V20211216
{
    public class GetInternetTupleResponseUnmarshaller
    {
        public static GetInternetTupleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInternetTupleResponse getInternetTupleResponse = new GetInternetTupleResponse();

			getInternetTupleResponse.HttpResponse = _ctx.HttpResponse;
			getInternetTupleResponse.RequestId = _ctx.StringValue("GetInternetTuple.RequestId");

			List<GetInternetTupleResponse.GetInternetTuple_DataItem> getInternetTupleResponse_data = new List<GetInternetTupleResponse.GetInternetTuple_DataItem>();
			for (int i = 0; i < _ctx.Length("GetInternetTuple.Data.Length"); i++) {
				GetInternetTupleResponse.GetInternetTuple_DataItem dataItem = new GetInternetTupleResponse.GetInternetTuple_DataItem();
				dataItem.BeginTime = _ctx.StringValue("GetInternetTuple.Data["+ i +"].BeginTime");
				dataItem.Direction = _ctx.StringValue("GetInternetTuple.Data["+ i +"].Direction");
				dataItem.InstanceId = _ctx.StringValue("GetInternetTuple.Data["+ i +"].InstanceId");
				dataItem.AccessRegion = _ctx.StringValue("GetInternetTuple.Data["+ i +"].AccessRegion");
				dataItem.CloudIp = _ctx.StringValue("GetInternetTuple.Data["+ i +"].CloudIp");
				dataItem.CloudPort = _ctx.StringValue("GetInternetTuple.Data["+ i +"].CloudPort");
				dataItem.OtherIp = _ctx.StringValue("GetInternetTuple.Data["+ i +"].OtherIp");
				dataItem.OtherPort = _ctx.StringValue("GetInternetTuple.Data["+ i +"].OtherPort");
				dataItem.Protocol = _ctx.StringValue("GetInternetTuple.Data["+ i +"].Protocol");
				dataItem.CloudCountry = _ctx.StringValue("GetInternetTuple.Data["+ i +"].CloudCountry");
				dataItem.CloudProvince = _ctx.StringValue("GetInternetTuple.Data["+ i +"].CloudProvince");
				dataItem.CloudCity = _ctx.StringValue("GetInternetTuple.Data["+ i +"].CloudCity");
				dataItem.CloudIsp = _ctx.StringValue("GetInternetTuple.Data["+ i +"].CloudIsp");
				dataItem.CloudProduct = _ctx.StringValue("GetInternetTuple.Data["+ i +"].CloudProduct");
				dataItem.OtherCountry = _ctx.StringValue("GetInternetTuple.Data["+ i +"].OtherCountry");
				dataItem.OtherProvince = _ctx.StringValue("GetInternetTuple.Data["+ i +"].OtherProvince");
				dataItem.OtherCity = _ctx.StringValue("GetInternetTuple.Data["+ i +"].OtherCity");
				dataItem.OtherIsp = _ctx.StringValue("GetInternetTuple.Data["+ i +"].OtherIsp");
				dataItem.OtherProduct = _ctx.StringValue("GetInternetTuple.Data["+ i +"].OtherProduct");
				dataItem.Rtt = _ctx.DoubleValue("GetInternetTuple.Data["+ i +"].Rtt");
				dataItem.ByteCount = _ctx.DoubleValue("GetInternetTuple.Data["+ i +"].ByteCount");
				dataItem.PacketCount = _ctx.DoubleValue("GetInternetTuple.Data["+ i +"].PacketCount");
				dataItem.OutOrderCount = _ctx.DoubleValue("GetInternetTuple.Data["+ i +"].OutOrderCount");
				dataItem.RetranCount = _ctx.DoubleValue("GetInternetTuple.Data["+ i +"].RetranCount");
				dataItem.InByteCount = _ctx.DoubleValue("GetInternetTuple.Data["+ i +"].InByteCount");
				dataItem.OutByteCount = _ctx.DoubleValue("GetInternetTuple.Data["+ i +"].OutByteCount");
				dataItem.InPacketCount = _ctx.DoubleValue("GetInternetTuple.Data["+ i +"].InPacketCount");
				dataItem.OutPacketCount = _ctx.DoubleValue("GetInternetTuple.Data["+ i +"].OutPacketCount");
				dataItem.InOutOrderCount = _ctx.DoubleValue("GetInternetTuple.Data["+ i +"].InOutOrderCount");
				dataItem.OutOutOrderCount = _ctx.DoubleValue("GetInternetTuple.Data["+ i +"].OutOutOrderCount");
				dataItem.InRetranCount = _ctx.DoubleValue("GetInternetTuple.Data["+ i +"].InRetranCount");
				dataItem.OutRetranCount = _ctx.DoubleValue("GetInternetTuple.Data["+ i +"].OutRetranCount");
				dataItem.RetransmitRate = _ctx.DoubleValue("GetInternetTuple.Data["+ i +"].RetransmitRate");

				getInternetTupleResponse_data.Add(dataItem);
			}
			getInternetTupleResponse.Data = getInternetTupleResponse_data;
        
			return getInternetTupleResponse;
        }
    }
}
