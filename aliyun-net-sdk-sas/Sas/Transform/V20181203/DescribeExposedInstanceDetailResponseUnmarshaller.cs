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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeExposedInstanceDetailResponseUnmarshaller
    {
        public static DescribeExposedInstanceDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeExposedInstanceDetailResponse describeExposedInstanceDetailResponse = new DescribeExposedInstanceDetailResponse();

			describeExposedInstanceDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeExposedInstanceDetailResponse.RequestId = _ctx.StringValue("DescribeExposedInstanceDetail.RequestId");

			List<DescribeExposedInstanceDetailResponse.DescribeExposedInstanceDetail_ExposedChain> describeExposedInstanceDetailResponse_exposedChains = new List<DescribeExposedInstanceDetailResponse.DescribeExposedInstanceDetail_ExposedChain>();
			for (int i = 0; i < _ctx.Length("DescribeExposedInstanceDetail.ExposedChains.Length"); i++) {
				DescribeExposedInstanceDetailResponse.DescribeExposedInstanceDetail_ExposedChain exposedChain = new DescribeExposedInstanceDetailResponse.DescribeExposedInstanceDetail_ExposedChain();
				exposedChain.Uuid = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].Uuid");
				exposedChain.IntranetIp = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].IntranetIp");
				exposedChain.InternetIp = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].InternetIp");
				exposedChain.ExposureComponent = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].ExposureComponent");
				exposedChain.ExposureType = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].ExposureType");
				exposedChain.ExposurePort = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].ExposurePort");
				exposedChain.ExposureIp = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].ExposureIp");
				exposedChain.ExposureTypeId = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].ExposureTypeId");
				exposedChain.InstanceId = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].InstanceId");
				exposedChain.InstanceName = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].InstanceName");
				exposedChain.RegionId = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].RegionId");
				exposedChain.GroupNo = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].GroupNo");

				List<DescribeExposedInstanceDetailResponse.DescribeExposedInstanceDetail_ExposedChain.DescribeExposedInstanceDetail_ScaVulRecord> exposedChain_realVulList = new List<DescribeExposedInstanceDetailResponse.DescribeExposedInstanceDetail_ExposedChain.DescribeExposedInstanceDetail_ScaVulRecord>();
				for (int j = 0; j < _ctx.Length("DescribeExposedInstanceDetail.ExposedChains["+ i +"].RealVulList.Length"); j++) {
					DescribeExposedInstanceDetailResponse.DescribeExposedInstanceDetail_ExposedChain.DescribeExposedInstanceDetail_ScaVulRecord scaVulRecord = new DescribeExposedInstanceDetailResponse.DescribeExposedInstanceDetail_ExposedChain.DescribeExposedInstanceDetail_ScaVulRecord();
					scaVulRecord.AliasName = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].RealVulList["+ j +"].AliasName");
					scaVulRecord.Necessity = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].RealVulList["+ j +"].Necessity");
					scaVulRecord.Name = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].RealVulList["+ j +"].Name");
					scaVulRecord.Type = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].RealVulList["+ j +"].Type");
					scaVulRecord.Uuid = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].RealVulList["+ j +"].Uuid");

					exposedChain_realVulList.Add(scaVulRecord);
				}
				exposedChain.RealVulList = exposedChain_realVulList;

				List<DescribeExposedInstanceDetailResponse.DescribeExposedInstanceDetail_ExposedChain.DescribeExposedInstanceDetail_ScaVulRecord> exposedChain_allVulList = new List<DescribeExposedInstanceDetailResponse.DescribeExposedInstanceDetail_ExposedChain.DescribeExposedInstanceDetail_ScaVulRecord>();
				for (int j = 0; j < _ctx.Length("DescribeExposedInstanceDetail.ExposedChains["+ i +"].AllVulList.Length"); j++) {
					DescribeExposedInstanceDetailResponse.DescribeExposedInstanceDetail_ExposedChain.DescribeExposedInstanceDetail_ScaVulRecord scaVulRecord = new DescribeExposedInstanceDetailResponse.DescribeExposedInstanceDetail_ExposedChain.DescribeExposedInstanceDetail_ScaVulRecord();
					scaVulRecord.AliasName = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].AllVulList["+ j +"].AliasName");
					scaVulRecord.Necessity = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].AllVulList["+ j +"].Necessity");
					scaVulRecord.Name = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].AllVulList["+ j +"].Name");
					scaVulRecord.Type = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].AllVulList["+ j +"].Type");
					scaVulRecord.Uuid = _ctx.StringValue("DescribeExposedInstanceDetail.ExposedChains["+ i +"].AllVulList["+ j +"].Uuid");

					exposedChain_allVulList.Add(scaVulRecord);
				}
				exposedChain.AllVulList = exposedChain_allVulList;

				describeExposedInstanceDetailResponse_exposedChains.Add(exposedChain);
			}
			describeExposedInstanceDetailResponse.ExposedChains = describeExposedInstanceDetailResponse_exposedChains;
        
			return describeExposedInstanceDetailResponse;
        }
    }
}
