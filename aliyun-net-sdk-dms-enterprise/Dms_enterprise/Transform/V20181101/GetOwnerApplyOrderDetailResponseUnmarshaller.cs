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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class GetOwnerApplyOrderDetailResponseUnmarshaller
    {
        public static GetOwnerApplyOrderDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOwnerApplyOrderDetailResponse getOwnerApplyOrderDetailResponse = new GetOwnerApplyOrderDetailResponse();

			getOwnerApplyOrderDetailResponse.HttpResponse = _ctx.HttpResponse;
			getOwnerApplyOrderDetailResponse.RequestId = _ctx.StringValue("GetOwnerApplyOrderDetail.RequestId");
			getOwnerApplyOrderDetailResponse.Success = _ctx.BooleanValue("GetOwnerApplyOrderDetail.Success");
			getOwnerApplyOrderDetailResponse.ErrorMessage = _ctx.StringValue("GetOwnerApplyOrderDetail.ErrorMessage");
			getOwnerApplyOrderDetailResponse.ErrorCode = _ctx.StringValue("GetOwnerApplyOrderDetail.ErrorCode");

			GetOwnerApplyOrderDetailResponse.GetOwnerApplyOrderDetail_OwnerApplyOrderDetail ownerApplyOrderDetail = new GetOwnerApplyOrderDetailResponse.GetOwnerApplyOrderDetail_OwnerApplyOrderDetail();
			ownerApplyOrderDetail.ApplyType = _ctx.StringValue("GetOwnerApplyOrderDetail.OwnerApplyOrderDetail.ApplyType");

			List<GetOwnerApplyOrderDetailResponse.GetOwnerApplyOrderDetail_OwnerApplyOrderDetail.GetOwnerApplyOrderDetail_Resource> ownerApplyOrderDetail_resources = new List<GetOwnerApplyOrderDetailResponse.GetOwnerApplyOrderDetail_OwnerApplyOrderDetail.GetOwnerApplyOrderDetail_Resource>();
			for (int i = 0; i < _ctx.Length("GetOwnerApplyOrderDetail.OwnerApplyOrderDetail.Resources.Length"); i++) {
				GetOwnerApplyOrderDetailResponse.GetOwnerApplyOrderDetail_OwnerApplyOrderDetail.GetOwnerApplyOrderDetail_Resource resource = new GetOwnerApplyOrderDetailResponse.GetOwnerApplyOrderDetail_OwnerApplyOrderDetail.GetOwnerApplyOrderDetail_Resource();
				resource.Logic = _ctx.BooleanValue("GetOwnerApplyOrderDetail.OwnerApplyOrderDetail.Resources["+ i +"].Logic");
				resource.TargetId = _ctx.StringValue("GetOwnerApplyOrderDetail.OwnerApplyOrderDetail.Resources["+ i +"].TargetId");

				GetOwnerApplyOrderDetailResponse.GetOwnerApplyOrderDetail_OwnerApplyOrderDetail.GetOwnerApplyOrderDetail_Resource.GetOwnerApplyOrderDetail_ResourceDetail resourceDetail = new GetOwnerApplyOrderDetailResponse.GetOwnerApplyOrderDetail_OwnerApplyOrderDetail.GetOwnerApplyOrderDetail_Resource.GetOwnerApplyOrderDetail_ResourceDetail();
				resourceDetail.SearchName = _ctx.StringValue("GetOwnerApplyOrderDetail.OwnerApplyOrderDetail.Resources["+ i +"].ResourceDetail.SearchName");
				resourceDetail.DbType = _ctx.StringValue("GetOwnerApplyOrderDetail.OwnerApplyOrderDetail.Resources["+ i +"].ResourceDetail.DbType");
				resourceDetail.EnvType = _ctx.StringValue("GetOwnerApplyOrderDetail.OwnerApplyOrderDetail.Resources["+ i +"].ResourceDetail.EnvType");
				resourceDetail.TableName = _ctx.StringValue("GetOwnerApplyOrderDetail.OwnerApplyOrderDetail.Resources["+ i +"].ResourceDetail.TableName");

				List<string> resourceDetail_ownerIds = new List<string>();
				for (int j = 0; j < _ctx.Length("GetOwnerApplyOrderDetail.OwnerApplyOrderDetail.Resources["+ i +"].ResourceDetail.OwnerIds.Length"); j++) {
					resourceDetail_ownerIds.Add(_ctx.StringValue("GetOwnerApplyOrderDetail.OwnerApplyOrderDetail.Resources["+ i +"].ResourceDetail.OwnerIds["+ j +"]"));
				}
				resourceDetail.OwnerIds = resourceDetail_ownerIds;

				List<string> resourceDetail_ownerNickNames = new List<string>();
				for (int j = 0; j < _ctx.Length("GetOwnerApplyOrderDetail.OwnerApplyOrderDetail.Resources["+ i +"].ResourceDetail.OwnerNickNames.Length"); j++) {
					resourceDetail_ownerNickNames.Add(_ctx.StringValue("GetOwnerApplyOrderDetail.OwnerApplyOrderDetail.Resources["+ i +"].ResourceDetail.OwnerNickNames["+ j +"]"));
				}
				resourceDetail.OwnerNickNames = resourceDetail_ownerNickNames;
				resource.ResourceDetail = resourceDetail;

				ownerApplyOrderDetail_resources.Add(resource);
			}
			ownerApplyOrderDetail.Resources = ownerApplyOrderDetail_resources;
			getOwnerApplyOrderDetailResponse.OwnerApplyOrderDetail = ownerApplyOrderDetail;
        
			return getOwnerApplyOrderDetailResponse;
        }
    }
}
