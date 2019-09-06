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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeExpressCloudConnectionsResponseUnmarshaller
    {
        public static DescribeExpressCloudConnectionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeExpressCloudConnectionsResponse describeExpressCloudConnectionsResponse = new DescribeExpressCloudConnectionsResponse();

			describeExpressCloudConnectionsResponse.HttpResponse = context.HttpResponse;
			describeExpressCloudConnectionsResponse.RequestId = context.StringValue("DescribeExpressCloudConnections.RequestId");
			describeExpressCloudConnectionsResponse.PageNumber = context.IntegerValue("DescribeExpressCloudConnections.PageNumber");
			describeExpressCloudConnectionsResponse.PageSize = context.IntegerValue("DescribeExpressCloudConnections.PageSize");
			describeExpressCloudConnectionsResponse.TotalCount = context.IntegerValue("DescribeExpressCloudConnections.TotalCount");

			List<DescribeExpressCloudConnectionsResponse.DescribeExpressCloudConnections_ExpressCloudConnectionType> describeExpressCloudConnectionsResponse_expressCloudConnectionSet = new List<DescribeExpressCloudConnectionsResponse.DescribeExpressCloudConnections_ExpressCloudConnectionType>();
			for (int i = 0; i < context.Length("DescribeExpressCloudConnections.ExpressCloudConnectionSet.Length"); i++) {
				DescribeExpressCloudConnectionsResponse.DescribeExpressCloudConnections_ExpressCloudConnectionType expressCloudConnectionType = new DescribeExpressCloudConnectionsResponse.DescribeExpressCloudConnections_ExpressCloudConnectionType();
				expressCloudConnectionType.InstanceId = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].InstanceId");
				expressCloudConnectionType.Status = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].Status");
				expressCloudConnectionType.Name = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].Name");
				expressCloudConnectionType.Description = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].Description");
				expressCloudConnectionType.GmtCreate = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].GmtCreate");
				expressCloudConnectionType.GmtModify = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].GmtModify");
				expressCloudConnectionType.PeerCity = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].PeerCity");
				expressCloudConnectionType.PeerLocation = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].PeerLocation");
				expressCloudConnectionType.PortType = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].PortType");
				expressCloudConnectionType.Bandwidth = context.IntegerValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].Bandwidth");
				expressCloudConnectionType.Distance = context.IntegerValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].Distance");
				expressCloudConnectionType.RedundantEccId = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].RedundantEccId");
				expressCloudConnectionType.CircuitCode = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].CircuitCode");
				expressCloudConnectionType.Isp = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].Isp");
				expressCloudConnectionType.Type = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].Type");
				expressCloudConnectionType.IdcSP = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].IdcSP");
				expressCloudConnectionType.BusinessStatus = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].BusinessStatus");
				expressCloudConnectionType.HasReservationData = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].HasReservationData");
				expressCloudConnectionType.ReservationBandwidth = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ReservationBandwidth");
				expressCloudConnectionType.ReservationInternetChargeType = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ReservationInternetChargeType");
				expressCloudConnectionType.ReservationActiveTime = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ReservationActiveTime");
				expressCloudConnectionType.ReservationOrderType = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ReservationOrderType");
				expressCloudConnectionType.ApplicationType = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ApplicationType");
				expressCloudConnectionType.ApplicationId = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ApplicationId");
				expressCloudConnectionType.ApplicationStatus = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ApplicationStatus");
				expressCloudConnectionType.ApplicationBandwidth = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ApplicationBandwidth");
				expressCloudConnectionType.ContactTel = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ContactTel");
				expressCloudConnectionType.ContactMail = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ContactMail");
				expressCloudConnectionType.IDCardNo = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].IDCardNo");
				expressCloudConnectionType.EndTime = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].EndTime");
				expressCloudConnectionType.ChargeType = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].ChargeType");

				List<DescribeExpressCloudConnectionsResponse.DescribeExpressCloudConnections_ExpressCloudConnectionType.DescribeExpressCloudConnections_VirtualBorderRouterModel> expressCloudConnectionType_virtualBorderRouterModels = new List<DescribeExpressCloudConnectionsResponse.DescribeExpressCloudConnections_ExpressCloudConnectionType.DescribeExpressCloudConnections_VirtualBorderRouterModel>();
				for (int j = 0; j < context.Length("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].VirtualBorderRouterModels.Length"); j++) {
					DescribeExpressCloudConnectionsResponse.DescribeExpressCloudConnections_ExpressCloudConnectionType.DescribeExpressCloudConnections_VirtualBorderRouterModel virtualBorderRouterModel = new DescribeExpressCloudConnectionsResponse.DescribeExpressCloudConnections_ExpressCloudConnectionType.DescribeExpressCloudConnections_VirtualBorderRouterModel();
					virtualBorderRouterModel.InstanceId = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].VirtualBorderRouterModels["+ j +"].InstanceId");
					virtualBorderRouterModel.AccessPointId = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].VirtualBorderRouterModels["+ j +"].AccessPointId");
					virtualBorderRouterModel.PhysicalConnectionId = context.StringValue("DescribeExpressCloudConnections.ExpressCloudConnectionSet["+ i +"].VirtualBorderRouterModels["+ j +"].PhysicalConnectionId");

					expressCloudConnectionType_virtualBorderRouterModels.Add(virtualBorderRouterModel);
				}
				expressCloudConnectionType.VirtualBorderRouterModels = expressCloudConnectionType_virtualBorderRouterModels;

				describeExpressCloudConnectionsResponse_expressCloudConnectionSet.Add(expressCloudConnectionType);
			}
			describeExpressCloudConnectionsResponse.ExpressCloudConnectionSet = describeExpressCloudConnectionsResponse_expressCloudConnectionSet;
        
			return describeExpressCloudConnectionsResponse;
        }
    }
}
