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
    public class DescribePhysicalConnectionLOAResponseUnmarshaller
    {
        public static DescribePhysicalConnectionLOAResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePhysicalConnectionLOAResponse describePhysicalConnectionLOAResponse = new DescribePhysicalConnectionLOAResponse();

			describePhysicalConnectionLOAResponse.HttpResponse = _ctx.HttpResponse;
			describePhysicalConnectionLOAResponse.RequestId = _ctx.StringValue("DescribePhysicalConnectionLOA.RequestId");

			DescribePhysicalConnectionLOAResponse.DescribePhysicalConnectionLOA_PhysicalConnectionLOAType physicalConnectionLOAType = new DescribePhysicalConnectionLOAResponse.DescribePhysicalConnectionLOA_PhysicalConnectionLOAType();
			physicalConnectionLOAType.InstanceId = _ctx.StringValue("DescribePhysicalConnectionLOA.PhysicalConnectionLOAType.InstanceId");
			physicalConnectionLOAType.CompanyName = _ctx.StringValue("DescribePhysicalConnectionLOA.PhysicalConnectionLOAType.CompanyName");
			physicalConnectionLOAType.CompanyLocalizedName = _ctx.StringValue("DescribePhysicalConnectionLOA.PhysicalConnectionLOAType.CompanyLocalizedName");
			physicalConnectionLOAType.LineType = _ctx.StringValue("DescribePhysicalConnectionLOA.PhysicalConnectionLOAType.LineType");
			physicalConnectionLOAType.LineCode = _ctx.StringValue("DescribePhysicalConnectionLOA.PhysicalConnectionLOAType.LineCode");
			physicalConnectionLOAType.LineLabel = _ctx.StringValue("DescribePhysicalConnectionLOA.PhysicalConnectionLOAType.LineLabel");
			physicalConnectionLOAType.ConstructionTime = _ctx.StringValue("DescribePhysicalConnectionLOA.PhysicalConnectionLOAType.ConstructionTime");
			physicalConnectionLOAType.Status = _ctx.StringValue("DescribePhysicalConnectionLOA.PhysicalConnectionLOAType.Status");
			physicalConnectionLOAType.LoaUrl = _ctx.StringValue("DescribePhysicalConnectionLOA.PhysicalConnectionLOAType.LoaUrl");
			physicalConnectionLOAType.SI = _ctx.StringValue("DescribePhysicalConnectionLOA.PhysicalConnectionLOAType.SI");

			List<DescribePhysicalConnectionLOAResponse.DescribePhysicalConnectionLOA_PhysicalConnectionLOAType.DescribePhysicalConnectionLOA_PMInfoItem> physicalConnectionLOAType_pMInfo = new List<DescribePhysicalConnectionLOAResponse.DescribePhysicalConnectionLOA_PhysicalConnectionLOAType.DescribePhysicalConnectionLOA_PMInfoItem>();
			for (int i = 0; i < _ctx.Length("DescribePhysicalConnectionLOA.PhysicalConnectionLOAType.PMInfo.Length"); i++) {
				DescribePhysicalConnectionLOAResponse.DescribePhysicalConnectionLOA_PhysicalConnectionLOAType.DescribePhysicalConnectionLOA_PMInfoItem pMInfoItem = new DescribePhysicalConnectionLOAResponse.DescribePhysicalConnectionLOA_PhysicalConnectionLOAType.DescribePhysicalConnectionLOA_PMInfoItem();
				pMInfoItem.PMName = _ctx.StringValue("DescribePhysicalConnectionLOA.PhysicalConnectionLOAType.PMInfo["+ i +"].PMName");
				pMInfoItem.PMContactInfo = _ctx.StringValue("DescribePhysicalConnectionLOA.PhysicalConnectionLOAType.PMInfo["+ i +"].PMContactInfo");
				pMInfoItem.PMCertificateType = _ctx.StringValue("DescribePhysicalConnectionLOA.PhysicalConnectionLOAType.PMInfo["+ i +"].PMCertificateType");
				pMInfoItem.PMCertificateNo = _ctx.StringValue("DescribePhysicalConnectionLOA.PhysicalConnectionLOAType.PMInfo["+ i +"].PMCertificateNo");
				pMInfoItem.PMGender = _ctx.StringValue("DescribePhysicalConnectionLOA.PhysicalConnectionLOAType.PMInfo["+ i +"].PMGender");

				physicalConnectionLOAType_pMInfo.Add(pMInfoItem);
			}
			physicalConnectionLOAType.PMInfo = physicalConnectionLOAType_pMInfo;
			describePhysicalConnectionLOAResponse.PhysicalConnectionLOAType = physicalConnectionLOAType;
        
			return describePhysicalConnectionLOAResponse;
        }
    }
}
