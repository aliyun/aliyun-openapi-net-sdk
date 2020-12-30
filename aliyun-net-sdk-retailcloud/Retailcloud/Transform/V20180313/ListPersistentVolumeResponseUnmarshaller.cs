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
    public class ListPersistentVolumeResponseUnmarshaller
    {
        public static ListPersistentVolumeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPersistentVolumeResponse listPersistentVolumeResponse = new ListPersistentVolumeResponse();

			listPersistentVolumeResponse.HttpResponse = _ctx.HttpResponse;
			listPersistentVolumeResponse.RequestId = _ctx.StringValue("ListPersistentVolume.RequestId");
			listPersistentVolumeResponse.Code = _ctx.IntegerValue("ListPersistentVolume.Code");
			listPersistentVolumeResponse.PageSize = _ctx.IntegerValue("ListPersistentVolume.PageSize");
			listPersistentVolumeResponse.PageNumber = _ctx.IntegerValue("ListPersistentVolume.PageNumber");
			listPersistentVolumeResponse.TotalCount = _ctx.LongValue("ListPersistentVolume.TotalCount");
			listPersistentVolumeResponse.ErrMsg = _ctx.StringValue("ListPersistentVolume.ErrMsg");

			List<ListPersistentVolumeResponse.ListPersistentVolume_PersistentVolumeDetail> listPersistentVolumeResponse_data = new List<ListPersistentVolumeResponse.ListPersistentVolume_PersistentVolumeDetail>();
			for (int i = 0; i < _ctx.Length("ListPersistentVolume.Data.Length"); i++) {
				ListPersistentVolumeResponse.ListPersistentVolume_PersistentVolumeDetail persistentVolumeDetail = new ListPersistentVolumeResponse.ListPersistentVolume_PersistentVolumeDetail();
				persistentVolumeDetail.Name = _ctx.StringValue("ListPersistentVolume.Data["+ i +"].Name");
				persistentVolumeDetail.Capacity = _ctx.StringValue("ListPersistentVolume.Data["+ i +"].Capacity");
				persistentVolumeDetail.AccessModes = _ctx.StringValue("ListPersistentVolume.Data["+ i +"].AccessModes");
				persistentVolumeDetail.ReclaimPolicy = _ctx.StringValue("ListPersistentVolume.Data["+ i +"].ReclaimPolicy");
				persistentVolumeDetail.Status = _ctx.StringValue("ListPersistentVolume.Data["+ i +"].Status");
				persistentVolumeDetail.PvcName = _ctx.StringValue("ListPersistentVolume.Data["+ i +"].PvcName");
				persistentVolumeDetail.MountDir = _ctx.StringValue("ListPersistentVolume.Data["+ i +"].MountDir");
				persistentVolumeDetail.StorageClass = _ctx.StringValue("ListPersistentVolume.Data["+ i +"].StorageClass");
				persistentVolumeDetail.Reason = _ctx.StringValue("ListPersistentVolume.Data["+ i +"].Reason");
				persistentVolumeDetail.CreateTime = _ctx.StringValue("ListPersistentVolume.Data["+ i +"].CreateTime");

				listPersistentVolumeResponse_data.Add(persistentVolumeDetail);
			}
			listPersistentVolumeResponse.Data = listPersistentVolumeResponse_data;
        
			return listPersistentVolumeResponse;
        }
    }
}
