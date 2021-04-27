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
    public class DescribeVpcHoneyPotListResponseUnmarshaller
    {
        public static DescribeVpcHoneyPotListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVpcHoneyPotListResponse describeVpcHoneyPotListResponse = new DescribeVpcHoneyPotListResponse();

			describeVpcHoneyPotListResponse.HttpResponse = _ctx.HttpResponse;
			describeVpcHoneyPotListResponse.RequestId = _ctx.StringValue("DescribeVpcHoneyPotList.RequestId");

			DescribeVpcHoneyPotListResponse.DescribeVpcHoneyPotList_PageInfo pageInfo = new DescribeVpcHoneyPotListResponse.DescribeVpcHoneyPotList_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribeVpcHoneyPotList.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeVpcHoneyPotList.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeVpcHoneyPotList.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeVpcHoneyPotList.PageInfo.CurrentPage");
			describeVpcHoneyPotListResponse.PageInfo = pageInfo;

			List<DescribeVpcHoneyPotListResponse.DescribeVpcHoneyPotList_VpcHoneyPotDTO> describeVpcHoneyPotListResponse_vpcHoneyPotDTOList = new List<DescribeVpcHoneyPotListResponse.DescribeVpcHoneyPotList_VpcHoneyPotDTO>();
			for (int i = 0; i < _ctx.Length("DescribeVpcHoneyPotList.VpcHoneyPotDTOList.Length"); i++) {
				DescribeVpcHoneyPotListResponse.DescribeVpcHoneyPotList_VpcHoneyPotDTO vpcHoneyPotDTO = new DescribeVpcHoneyPotListResponse.DescribeVpcHoneyPotList_VpcHoneyPotDTO();
				vpcHoneyPotDTO.VpcId = _ctx.StringValue("DescribeVpcHoneyPotList.VpcHoneyPotDTOList["+ i +"].VpcId");
				vpcHoneyPotDTO.VpcName = _ctx.StringValue("DescribeVpcHoneyPotList.VpcHoneyPotDTOList["+ i +"].VpcName");
				vpcHoneyPotDTO.VpcRegionId = _ctx.StringValue("DescribeVpcHoneyPotList.VpcHoneyPotDTOList["+ i +"].VpcRegionId");
				vpcHoneyPotDTO.CreateTime = _ctx.LongValue("DescribeVpcHoneyPotList.VpcHoneyPotDTOList["+ i +"].CreateTime");
				vpcHoneyPotDTO.VpcStatus = _ctx.StringValue("DescribeVpcHoneyPotList.VpcHoneyPotDTOList["+ i +"].VpcStatus");
				vpcHoneyPotDTO.CidrBlock = _ctx.StringValue("DescribeVpcHoneyPotList.VpcHoneyPotDTOList["+ i +"].CidrBlock");
				vpcHoneyPotDTO.HoneyPotExistence = _ctx.BooleanValue("DescribeVpcHoneyPotList.VpcHoneyPotDTOList["+ i +"].HoneyPotExistence");
				vpcHoneyPotDTO.HoneyPotVpcSwitchId = _ctx.StringValue("DescribeVpcHoneyPotList.VpcHoneyPotDTOList["+ i +"].HoneyPotVpcSwitchId");
				vpcHoneyPotDTO.HoneyPotInstanceStatus = _ctx.StringValue("DescribeVpcHoneyPotList.VpcHoneyPotDTOList["+ i +"].HoneyPotInstanceStatus");
				vpcHoneyPotDTO.HoneyPotEniInstanceId = _ctx.StringValue("DescribeVpcHoneyPotList.VpcHoneyPotDTOList["+ i +"].HoneyPotEniInstanceId");
				vpcHoneyPotDTO.HoneyPotEcsInstanceStatus = _ctx.StringValue("DescribeVpcHoneyPotList.VpcHoneyPotDTOList["+ i +"].HoneyPotEcsInstanceStatus");

				List<DescribeVpcHoneyPotListResponse.DescribeVpcHoneyPotList_VpcHoneyPotDTO.DescribeVpcHoneyPotList_VpcSwitchInfo> vpcHoneyPotDTO_vpcSwitchIdList = new List<DescribeVpcHoneyPotListResponse.DescribeVpcHoneyPotList_VpcHoneyPotDTO.DescribeVpcHoneyPotList_VpcSwitchInfo>();
				for (int j = 0; j < _ctx.Length("DescribeVpcHoneyPotList.VpcHoneyPotDTOList["+ i +"].VpcSwitchIdList.Length"); j++) {
					DescribeVpcHoneyPotListResponse.DescribeVpcHoneyPotList_VpcHoneyPotDTO.DescribeVpcHoneyPotList_VpcSwitchInfo vpcSwitchInfo = new DescribeVpcHoneyPotListResponse.DescribeVpcHoneyPotList_VpcHoneyPotDTO.DescribeVpcHoneyPotList_VpcSwitchInfo();
					vpcSwitchInfo.VpcSwitchId = _ctx.StringValue("DescribeVpcHoneyPotList.VpcHoneyPotDTOList["+ i +"].VpcSwitchIdList["+ j +"].VpcSwitchId");
					vpcSwitchInfo.VpcSwitchName = _ctx.StringValue("DescribeVpcHoneyPotList.VpcHoneyPotDTOList["+ i +"].VpcSwitchIdList["+ j +"].VpcSwitchName");
					vpcSwitchInfo.ZoneId = _ctx.StringValue("DescribeVpcHoneyPotList.VpcHoneyPotDTOList["+ i +"].VpcSwitchIdList["+ j +"].ZoneId");

					vpcHoneyPotDTO_vpcSwitchIdList.Add(vpcSwitchInfo);
				}
				vpcHoneyPotDTO.VpcSwitchIdList = vpcHoneyPotDTO_vpcSwitchIdList;

				describeVpcHoneyPotListResponse_vpcHoneyPotDTOList.Add(vpcHoneyPotDTO);
			}
			describeVpcHoneyPotListResponse.VpcHoneyPotDTOList = describeVpcHoneyPotListResponse_vpcHoneyPotDTOList;
        
			return describeVpcHoneyPotListResponse;
        }
    }
}
