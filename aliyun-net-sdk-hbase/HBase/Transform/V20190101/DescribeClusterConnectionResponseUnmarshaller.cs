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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class DescribeClusterConnectionResponseUnmarshaller
    {
        public static DescribeClusterConnectionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClusterConnectionResponse describeClusterConnectionResponse = new DescribeClusterConnectionResponse();

			describeClusterConnectionResponse.HttpResponse = _ctx.HttpResponse;
			describeClusterConnectionResponse.RequestId = _ctx.StringValue("DescribeClusterConnection.RequestId");
			describeClusterConnectionResponse.NetType = _ctx.StringValue("DescribeClusterConnection.NetType");
			describeClusterConnectionResponse.VpcId = _ctx.StringValue("DescribeClusterConnection.VpcId");
			describeClusterConnectionResponse.VSwitchId = _ctx.StringValue("DescribeClusterConnection.VSwitchId");
			describeClusterConnectionResponse.DbType = _ctx.StringValue("DescribeClusterConnection.DbType");
			describeClusterConnectionResponse.IsMultimod = _ctx.StringValue("DescribeClusterConnection.IsMultimod");

			DescribeClusterConnectionResponse.DescribeClusterConnection_UiProxyConnAddrInfo uiProxyConnAddrInfo = new DescribeClusterConnectionResponse.DescribeClusterConnection_UiProxyConnAddrInfo();
			uiProxyConnAddrInfo.ConnAddr = _ctx.StringValue("DescribeClusterConnection.UiProxyConnAddrInfo.ConnAddr");
			uiProxyConnAddrInfo.ConnAddrPort = _ctx.StringValue("DescribeClusterConnection.UiProxyConnAddrInfo.ConnAddrPort");
			uiProxyConnAddrInfo.NetType = _ctx.StringValue("DescribeClusterConnection.UiProxyConnAddrInfo.NetType");
			describeClusterConnectionResponse.UiProxyConnAddrInfo = uiProxyConnAddrInfo;

			DescribeClusterConnectionResponse.DescribeClusterConnection_ThriftConn thriftConn = new DescribeClusterConnectionResponse.DescribeClusterConnection_ThriftConn();
			thriftConn.ConnAddr = _ctx.StringValue("DescribeClusterConnection.ThriftConn.ConnAddr");
			thriftConn.ConnAddrPort = _ctx.StringValue("DescribeClusterConnection.ThriftConn.ConnAddrPort");
			thriftConn.NetType = _ctx.StringValue("DescribeClusterConnection.ThriftConn.NetType");
			describeClusterConnectionResponse.ThriftConn = thriftConn;

			List<DescribeClusterConnectionResponse.DescribeClusterConnection_ZkConnAddr> describeClusterConnectionResponse_zkConnAddrs = new List<DescribeClusterConnectionResponse.DescribeClusterConnection_ZkConnAddr>();
			for (int i = 0; i < _ctx.Length("DescribeClusterConnection.ZkConnAddrs.Length"); i++) {
				DescribeClusterConnectionResponse.DescribeClusterConnection_ZkConnAddr zkConnAddr = new DescribeClusterConnectionResponse.DescribeClusterConnection_ZkConnAddr();
				zkConnAddr.ConnAddr = _ctx.StringValue("DescribeClusterConnection.ZkConnAddrs["+ i +"].ConnAddr");
				zkConnAddr.ConnAddrPort = _ctx.StringValue("DescribeClusterConnection.ZkConnAddrs["+ i +"].ConnAddrPort");
				zkConnAddr.NetType = _ctx.StringValue("DescribeClusterConnection.ZkConnAddrs["+ i +"].NetType");

				describeClusterConnectionResponse_zkConnAddrs.Add(zkConnAddr);
			}
			describeClusterConnectionResponse.ZkConnAddrs = describeClusterConnectionResponse_zkConnAddrs;

			List<DescribeClusterConnectionResponse.DescribeClusterConnection_SlbConnAddr> describeClusterConnectionResponse_slbConnAddrs = new List<DescribeClusterConnectionResponse.DescribeClusterConnection_SlbConnAddr>();
			for (int i = 0; i < _ctx.Length("DescribeClusterConnection.SlbConnAddrs.Length"); i++) {
				DescribeClusterConnectionResponse.DescribeClusterConnection_SlbConnAddr slbConnAddr = new DescribeClusterConnectionResponse.DescribeClusterConnection_SlbConnAddr();
				slbConnAddr.SlbType = _ctx.StringValue("DescribeClusterConnection.SlbConnAddrs["+ i +"].SlbType");

				DescribeClusterConnectionResponse.DescribeClusterConnection_SlbConnAddr.DescribeClusterConnection_ConnAddrInfo connAddrInfo = new DescribeClusterConnectionResponse.DescribeClusterConnection_SlbConnAddr.DescribeClusterConnection_ConnAddrInfo();
				connAddrInfo.ConnAddr = _ctx.StringValue("DescribeClusterConnection.SlbConnAddrs["+ i +"].ConnAddrInfo.ConnAddr");
				connAddrInfo.ConnAddrPort = _ctx.StringValue("DescribeClusterConnection.SlbConnAddrs["+ i +"].ConnAddrInfo.ConnAddrPort");
				connAddrInfo.NetType = _ctx.StringValue("DescribeClusterConnection.SlbConnAddrs["+ i +"].ConnAddrInfo.NetType");
				slbConnAddr.ConnAddrInfo = connAddrInfo;

				describeClusterConnectionResponse_slbConnAddrs.Add(slbConnAddr);
			}
			describeClusterConnectionResponse.SlbConnAddrs = describeClusterConnectionResponse_slbConnAddrs;

			List<DescribeClusterConnectionResponse.DescribeClusterConnection_ServiceConnAddr> describeClusterConnectionResponse_serviceConnAddrs = new List<DescribeClusterConnectionResponse.DescribeClusterConnection_ServiceConnAddr>();
			for (int i = 0; i < _ctx.Length("DescribeClusterConnection.ServiceConnAddrs.Length"); i++) {
				DescribeClusterConnectionResponse.DescribeClusterConnection_ServiceConnAddr serviceConnAddr = new DescribeClusterConnectionResponse.DescribeClusterConnection_ServiceConnAddr();
				serviceConnAddr.ConnType = _ctx.StringValue("DescribeClusterConnection.ServiceConnAddrs["+ i +"].ConnType");

				DescribeClusterConnectionResponse.DescribeClusterConnection_ServiceConnAddr.DescribeClusterConnection_ConnAddrInfo1 connAddrInfo1 = new DescribeClusterConnectionResponse.DescribeClusterConnection_ServiceConnAddr.DescribeClusterConnection_ConnAddrInfo1();
				connAddrInfo1.ConnAddr = _ctx.StringValue("DescribeClusterConnection.ServiceConnAddrs["+ i +"].ConnAddrInfo.ConnAddr");
				connAddrInfo1.ConnAddrPort = _ctx.StringValue("DescribeClusterConnection.ServiceConnAddrs["+ i +"].ConnAddrInfo.ConnAddrPort");
				connAddrInfo1.NetType = _ctx.StringValue("DescribeClusterConnection.ServiceConnAddrs["+ i +"].ConnAddrInfo.NetType");
				serviceConnAddr.ConnAddrInfo1 = connAddrInfo1;

				describeClusterConnectionResponse_serviceConnAddrs.Add(serviceConnAddr);
			}
			describeClusterConnectionResponse.ServiceConnAddrs = describeClusterConnectionResponse_serviceConnAddrs;
        
			return describeClusterConnectionResponse;
        }
    }
}
