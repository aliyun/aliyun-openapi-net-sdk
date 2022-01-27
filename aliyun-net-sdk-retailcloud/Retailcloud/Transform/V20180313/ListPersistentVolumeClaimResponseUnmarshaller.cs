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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class ListPersistentVolumeClaimResponseUnmarshaller
    {
        public static ListPersistentVolumeClaimResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPersistentVolumeClaimResponse listPersistentVolumeClaimResponse = new ListPersistentVolumeClaimResponse();

			listPersistentVolumeClaimResponse.HttpResponse = _ctx.HttpResponse;
			listPersistentVolumeClaimResponse.Code = _ctx.IntegerValue("ListPersistentVolumeClaim.Code");
			listPersistentVolumeClaimResponse.PageNumber = _ctx.IntegerValue("ListPersistentVolumeClaim.PageNumber");
			listPersistentVolumeClaimResponse.RequestId = _ctx.StringValue("ListPersistentVolumeClaim.RequestId");
			listPersistentVolumeClaimResponse.PageSize = _ctx.IntegerValue("ListPersistentVolumeClaim.PageSize");
			listPersistentVolumeClaimResponse.TotalCount = _ctx.LongValue("ListPersistentVolumeClaim.TotalCount");
			listPersistentVolumeClaimResponse.ErrorMsg = _ctx.StringValue("ListPersistentVolumeClaim.ErrorMsg");

			List<ListPersistentVolumeClaimResponse.ListPersistentVolumeClaim_PersistentVolumeClaimDetail> listPersistentVolumeClaimResponse_data = new List<ListPersistentVolumeClaimResponse.ListPersistentVolumeClaim_PersistentVolumeClaimDetail>();
			for (int i = 0; i < _ctx.Length("ListPersistentVolumeClaim.Data.Length"); i++) {
				ListPersistentVolumeClaimResponse.ListPersistentVolumeClaim_PersistentVolumeClaimDetail persistentVolumeClaimDetail = new ListPersistentVolumeClaimResponse.ListPersistentVolumeClaim_PersistentVolumeClaimDetail();
				persistentVolumeClaimDetail.Name = _ctx.StringValue("ListPersistentVolumeClaim.Data["+ i +"].Name");
				persistentVolumeClaimDetail.Capacity = _ctx.StringValue("ListPersistentVolumeClaim.Data["+ i +"].Capacity");
				persistentVolumeClaimDetail.AccessModes = _ctx.StringValue("ListPersistentVolumeClaim.Data["+ i +"].AccessModes");
				persistentVolumeClaimDetail.Status = _ctx.StringValue("ListPersistentVolumeClaim.Data["+ i +"].Status");
				persistentVolumeClaimDetail.StorageClass = _ctx.StringValue("ListPersistentVolumeClaim.Data["+ i +"].StorageClass");
				persistentVolumeClaimDetail.VolumeName = _ctx.StringValue("ListPersistentVolumeClaim.Data["+ i +"].VolumeName");
				persistentVolumeClaimDetail.CreateTime = _ctx.StringValue("ListPersistentVolumeClaim.Data["+ i +"].CreateTime");

				listPersistentVolumeClaimResponse_data.Add(persistentVolumeClaimDetail);
			}
			listPersistentVolumeClaimResponse.Data = listPersistentVolumeClaimResponse_data;
        
			return listPersistentVolumeClaimResponse;
        }
    }
}
