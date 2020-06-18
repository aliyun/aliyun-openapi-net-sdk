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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeCrossBackupMetaListResponseUnmarshaller
    {
        public static DescribeCrossBackupMetaListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCrossBackupMetaListResponse describeCrossBackupMetaListResponse = new DescribeCrossBackupMetaListResponse();

			describeCrossBackupMetaListResponse.HttpResponse = context.HttpResponse;
			describeCrossBackupMetaListResponse.RequestId = context.StringValue("DescribeCrossBackupMetaList.RequestId");
			describeCrossBackupMetaListResponse.DBInstanceName = context.StringValue("DescribeCrossBackupMetaList.DBInstanceName");
			describeCrossBackupMetaListResponse.PageNumber = context.IntegerValue("DescribeCrossBackupMetaList.PageNumber");
			describeCrossBackupMetaListResponse.PageRecordCount = context.IntegerValue("DescribeCrossBackupMetaList.PageRecordCount");
			describeCrossBackupMetaListResponse.TotalRecordCount = context.IntegerValue("DescribeCrossBackupMetaList.TotalRecordCount");
			describeCrossBackupMetaListResponse.TotalPageCount = context.IntegerValue("DescribeCrossBackupMetaList.TotalPageCount");

			List<DescribeCrossBackupMetaListResponse.DescribeCrossBackupMetaList_Meta> describeCrossBackupMetaListResponse_items = new List<DescribeCrossBackupMetaListResponse.DescribeCrossBackupMetaList_Meta>();
			for (int i = 0; i < context.Length("DescribeCrossBackupMetaList.Items.Length"); i++) {
				DescribeCrossBackupMetaListResponse.DescribeCrossBackupMetaList_Meta meta = new DescribeCrossBackupMetaListResponse.DescribeCrossBackupMetaList_Meta();
				meta.Database = context.StringValue("DescribeCrossBackupMetaList.Items["+ i +"].Database");
				meta.Tables = context.StringValue("DescribeCrossBackupMetaList.Items["+ i +"].Tables");
				meta.Size = context.StringValue("DescribeCrossBackupMetaList.Items["+ i +"].Size");

				describeCrossBackupMetaListResponse_items.Add(meta);
			}
			describeCrossBackupMetaListResponse.Items = describeCrossBackupMetaListResponse_items;
        
			return describeCrossBackupMetaListResponse;
        }
    }
}
