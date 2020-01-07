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
        public static ListPersistentVolumeResponse Unmarshall(UnmarshallerContext context)
        {
			ListPersistentVolumeResponse listPersistentVolumeResponse = new ListPersistentVolumeResponse();

			listPersistentVolumeResponse.HttpResponse = context.HttpResponse;
			listPersistentVolumeResponse.RequestId = context.StringValue("ListPersistentVolume.RequestId");
			listPersistentVolumeResponse.Code = context.IntegerValue("ListPersistentVolume.Code");
			listPersistentVolumeResponse.PageSize = context.IntegerValue("ListPersistentVolume.PageSize");
			listPersistentVolumeResponse.PageNumber = context.IntegerValue("ListPersistentVolume.PageNumber");
			listPersistentVolumeResponse.TotalCount = context.LongValue("ListPersistentVolume.TotalCount");
			listPersistentVolumeResponse.ErrMsg = context.StringValue("ListPersistentVolume.ErrMsg");

			List<ListPersistentVolumeResponse.ListPersistentVolume_ListPersistentVolumeResponse1> listPersistentVolumeResponse_data = new List<ListPersistentVolumeResponse.ListPersistentVolume_ListPersistentVolumeResponse1>();
			for (int i = 0; i < context.Length("ListPersistentVolume.Data.Length"); i++) {
				ListPersistentVolumeResponse.ListPersistentVolume_ListPersistentVolumeResponse1 listPersistentVolumeResponse1 = new ListPersistentVolumeResponse.ListPersistentVolume_ListPersistentVolumeResponse1();
				listPersistentVolumeResponse1.Name = context.StringValue("ListPersistentVolume.Data["+ i +"].Name");
				listPersistentVolumeResponse1.Capacity = context.StringValue("ListPersistentVolume.Data["+ i +"].Capacity");
				listPersistentVolumeResponse1.AccessModes = context.StringValue("ListPersistentVolume.Data["+ i +"].AccessModes");
				listPersistentVolumeResponse1.ReclaimPolicy = context.StringValue("ListPersistentVolume.Data["+ i +"].ReclaimPolicy");
				listPersistentVolumeResponse1.Status = context.StringValue("ListPersistentVolume.Data["+ i +"].Status");
				listPersistentVolumeResponse1.PvcName = context.StringValue("ListPersistentVolume.Data["+ i +"].PvcName");
				listPersistentVolumeResponse1.MountDir = context.StringValue("ListPersistentVolume.Data["+ i +"].MountDir");
				listPersistentVolumeResponse1.StorageClass = context.StringValue("ListPersistentVolume.Data["+ i +"].StorageClass");
				listPersistentVolumeResponse1.Reason = context.StringValue("ListPersistentVolume.Data["+ i +"].Reason");
				listPersistentVolumeResponse1.CreateTime = context.StringValue("ListPersistentVolume.Data["+ i +"].CreateTime");

				listPersistentVolumeResponse_data.Add(listPersistentVolumeResponse1);
			}
			listPersistentVolumeResponse.Data = listPersistentVolumeResponse_data;
        
			return listPersistentVolumeResponse;
        }
    }
}
