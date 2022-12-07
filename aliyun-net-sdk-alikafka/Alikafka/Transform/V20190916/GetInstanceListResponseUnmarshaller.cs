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
using Aliyun.Acs.alikafka.Model.V20190916;

namespace Aliyun.Acs.alikafka.Transform.V20190916
{
    public class GetInstanceListResponseUnmarshaller
    {
        public static GetInstanceListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInstanceListResponse getInstanceListResponse = new GetInstanceListResponse();

			getInstanceListResponse.HttpResponse = _ctx.HttpResponse;
			getInstanceListResponse.Code = _ctx.IntegerValue("GetInstanceList.Code");
			getInstanceListResponse.Message = _ctx.StringValue("GetInstanceList.Message");
			getInstanceListResponse.RequestId = _ctx.StringValue("GetInstanceList.RequestId");
			getInstanceListResponse.Success = _ctx.BooleanValue("GetInstanceList.Success");

			List<GetInstanceListResponse.GetInstanceList_InstanceVO> getInstanceListResponse_instanceList = new List<GetInstanceListResponse.GetInstanceList_InstanceVO>();
			for (int i = 0; i < _ctx.Length("GetInstanceList.InstanceList.Length"); i++) {
				GetInstanceListResponse.GetInstanceList_InstanceVO instanceVO = new GetInstanceListResponse.GetInstanceList_InstanceVO();
				instanceVO.VpcId = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].VpcId");
				instanceVO.SpecType = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].SpecType");
				instanceVO.DeployType = _ctx.IntegerValue("GetInstanceList.InstanceList["+ i +"].DeployType");
				instanceVO.CreateTime = _ctx.LongValue("GetInstanceList.InstanceList["+ i +"].CreateTime");
				instanceVO.DiskSize = _ctx.IntegerValue("GetInstanceList.InstanceList["+ i +"].DiskSize");
				instanceVO.DiskType = _ctx.IntegerValue("GetInstanceList.InstanceList["+ i +"].DiskType");
				instanceVO.SecurityGroup = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].SecurityGroup");
				instanceVO.SslEndPoint = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].SslEndPoint");
				instanceVO.InstanceId = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].InstanceId");
				instanceVO.AllConfig = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].AllConfig");
				instanceVO.ServiceStatus = _ctx.IntegerValue("GetInstanceList.InstanceList["+ i +"].ServiceStatus");
				instanceVO.EipMax = _ctx.IntegerValue("GetInstanceList.InstanceList["+ i +"].EipMax");
				instanceVO.RegionId = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].RegionId");
				instanceVO.MsgRetain = _ctx.IntegerValue("GetInstanceList.InstanceList["+ i +"].MsgRetain");
				instanceVO.VSwitchId = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].VSwitchId");
				instanceVO.ExpiredTime = _ctx.LongValue("GetInstanceList.InstanceList["+ i +"].ExpiredTime");
				instanceVO.TopicNumLimit = _ctx.IntegerValue("GetInstanceList.InstanceList["+ i +"].TopicNumLimit");
				instanceVO.ZoneId = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].ZoneId");
				instanceVO.IoMax = _ctx.IntegerValue("GetInstanceList.InstanceList["+ i +"].IoMax");
				instanceVO.PaidType = _ctx.IntegerValue("GetInstanceList.InstanceList["+ i +"].PaidType");
				instanceVO.Name = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].Name");
				instanceVO.EndPoint = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].EndPoint");
				instanceVO.DomainEndpoint = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].DomainEndpoint");
				instanceVO.SslDomainEndpoint = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].SslDomainEndpoint");
				instanceVO.SaslDomainEndpoint = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].SaslDomainEndpoint");
				instanceVO.ResourceGroupId = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].ResourceGroupId");
				instanceVO.UsedTopicCount = _ctx.IntegerValue("GetInstanceList.InstanceList["+ i +"].UsedTopicCount");
				instanceVO.UsedGroupCount = _ctx.IntegerValue("GetInstanceList.InstanceList["+ i +"].UsedGroupCount");
				instanceVO.UsedPartitionCount = _ctx.IntegerValue("GetInstanceList.InstanceList["+ i +"].UsedPartitionCount");
				instanceVO.KmsKeyId = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].KmsKeyId");
				instanceVO.StandardZoneId = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].StandardZoneId");

				GetInstanceListResponse.GetInstanceList_InstanceVO.GetInstanceList_UpgradeServiceDetailInfo upgradeServiceDetailInfo = new GetInstanceListResponse.GetInstanceList_InstanceVO.GetInstanceList_UpgradeServiceDetailInfo();
				upgradeServiceDetailInfo.Current2OpenSourceVersion = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].UpgradeServiceDetailInfo.Current2OpenSourceVersion");
				instanceVO.UpgradeServiceDetailInfo = upgradeServiceDetailInfo;

				List<GetInstanceListResponse.GetInstanceList_InstanceVO.GetInstanceList_TagVO> instanceVO_tags = new List<GetInstanceListResponse.GetInstanceList_InstanceVO.GetInstanceList_TagVO>();
				for (int j = 0; j < _ctx.Length("GetInstanceList.InstanceList["+ i +"].Tags.Length"); j++) {
					GetInstanceListResponse.GetInstanceList_InstanceVO.GetInstanceList_TagVO tagVO = new GetInstanceListResponse.GetInstanceList_InstanceVO.GetInstanceList_TagVO();
					tagVO.Key = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].Tags["+ j +"].Key");
					tagVO._Value = _ctx.StringValue("GetInstanceList.InstanceList["+ i +"].Tags["+ j +"].Value");

					instanceVO_tags.Add(tagVO);
				}
				instanceVO.Tags = instanceVO_tags;

				getInstanceListResponse_instanceList.Add(instanceVO);
			}
			getInstanceListResponse.InstanceList = getInstanceListResponse_instanceList;
        
			return getInstanceListResponse;
        }
    }
}
