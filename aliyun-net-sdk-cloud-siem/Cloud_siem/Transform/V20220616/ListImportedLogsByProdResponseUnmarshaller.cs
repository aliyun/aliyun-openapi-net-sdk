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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class ListImportedLogsByProdResponseUnmarshaller
    {
        public static ListImportedLogsByProdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListImportedLogsByProdResponse listImportedLogsByProdResponse = new ListImportedLogsByProdResponse();

			listImportedLogsByProdResponse.HttpResponse = _ctx.HttpResponse;
			listImportedLogsByProdResponse.RequestId = _ctx.StringValue("ListImportedLogsByProd.RequestId");

			List<ListImportedLogsByProdResponse.ListImportedLogsByProd_DataItem> listImportedLogsByProdResponse_data = new List<ListImportedLogsByProdResponse.ListImportedLogsByProd_DataItem>();
			for (int i = 0; i < _ctx.Length("ListImportedLogsByProd.Data.Length"); i++) {
				ListImportedLogsByProdResponse.ListImportedLogsByProd_DataItem dataItem = new ListImportedLogsByProdResponse.ListImportedLogsByProd_DataItem();
				dataItem.ProdCode = _ctx.StringValue("ListImportedLogsByProd.Data["+ i +"].ProdCode");
				dataItem.LogCode = _ctx.StringValue("ListImportedLogsByProd.Data["+ i +"].LogCode");
				dataItem.LogMdsCode = _ctx.StringValue("ListImportedLogsByProd.Data["+ i +"].LogMdsCode");
				dataItem.ImportedUserCount = _ctx.IntegerValue("ListImportedLogsByProd.Data["+ i +"].ImportedUserCount");
				dataItem.UnImportedUserCount = _ctx.IntegerValue("ListImportedLogsByProd.Data["+ i +"].UnImportedUserCount");
				dataItem.TotalUserCount = _ctx.IntegerValue("ListImportedLogsByProd.Data["+ i +"].TotalUserCount");
				dataItem.ModifyTime = _ctx.StringValue("ListImportedLogsByProd.Data["+ i +"].ModifyTime");
				dataItem.Imported = _ctx.IntegerValue("ListImportedLogsByProd.Data["+ i +"].Imported");
				dataItem.AutoImported = _ctx.IntegerValue("ListImportedLogsByProd.Data["+ i +"].AutoImported");
				dataItem.LogType = _ctx.IntegerValue("ListImportedLogsByProd.Data["+ i +"].LogType");
				dataItem.CloudCode = _ctx.StringValue("ListImportedLogsByProd.Data["+ i +"].CloudCode");

				listImportedLogsByProdResponse_data.Add(dataItem);
			}
			listImportedLogsByProdResponse.Data = listImportedLogsByProdResponse_data;
        
			return listImportedLogsByProdResponse;
        }
    }
}
