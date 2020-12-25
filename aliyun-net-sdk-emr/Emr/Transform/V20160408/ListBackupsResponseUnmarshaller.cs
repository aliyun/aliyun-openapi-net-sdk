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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListBackupsResponseUnmarshaller
    {
        public static ListBackupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListBackupsResponse listBackupsResponse = new ListBackupsResponse();

			listBackupsResponse.HttpResponse = _ctx.HttpResponse;
			listBackupsResponse.RequestId = _ctx.StringValue("ListBackups.RequestId");
			listBackupsResponse.PageNumber = _ctx.IntegerValue("ListBackups.PageNumber");
			listBackupsResponse.PageSize = _ctx.IntegerValue("ListBackups.PageSize");
			listBackupsResponse.TotalCount = _ctx.IntegerValue("ListBackups.TotalCount");

			List<ListBackupsResponse.ListBackups_Item> listBackupsResponse_items = new List<ListBackupsResponse.ListBackups_Item>();
			for (int i = 0; i < _ctx.Length("ListBackups.Items.Length"); i++) {
				ListBackupsResponse.ListBackups_Item item = new ListBackupsResponse.ListBackups_Item();
				item.Id = _ctx.StringValue("ListBackups.Items["+ i +"].Id");
				item.BackupPlanId = _ctx.StringValue("ListBackups.Items["+ i +"].BackupPlanId");
				item.ClusterId = _ctx.StringValue("ListBackups.Items["+ i +"].ClusterId");
				item.CreateTime = _ctx.LongValue("ListBackups.Items["+ i +"].CreateTime");
				item.Md5 = _ctx.StringValue("ListBackups.Items["+ i +"].Md5");
				item.TarFileName = _ctx.StringValue("ListBackups.Items["+ i +"].TarFileName");
				item.StorePath = _ctx.StringValue("ListBackups.Items["+ i +"].StorePath");
				item.Status = _ctx.StringValue("ListBackups.Items["+ i +"].Status");

				ListBackupsResponse.ListBackups_Item.ListBackups_MetadataInfo metadataInfo = new ListBackupsResponse.ListBackups_Item.ListBackups_MetadataInfo();
				metadataInfo.MetadataType = _ctx.StringValue("ListBackups.Items["+ i +"].MetadataInfo.MetadataType");
				metadataInfo.Properties = _ctx.StringValue("ListBackups.Items["+ i +"].MetadataInfo.Properties");
				item.MetadataInfo = metadataInfo;

				listBackupsResponse_items.Add(item);
			}
			listBackupsResponse.Items = listBackupsResponse_items;
        
			return listBackupsResponse;
        }
    }
}
