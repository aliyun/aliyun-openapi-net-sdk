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
using Aliyun.Acs.imgsearch.Model.V20200320;

namespace Aliyun.Acs.imgsearch.Transform.V20200320
{
    public class ListImageDbsResponseUnmarshaller
    {
        public static ListImageDbsResponse Unmarshall(UnmarshallerContext context)
        {
			ListImageDbsResponse listImageDbsResponse = new ListImageDbsResponse();

			listImageDbsResponse.HttpResponse = context.HttpResponse;
			listImageDbsResponse.RequestId = context.StringValue("ListImageDbs.RequestId");

			ListImageDbsResponse.ListImageDbs_Data data = new ListImageDbsResponse.ListImageDbs_Data();

			List<ListImageDbsResponse.ListImageDbs_Data.ListImageDbs_DbListItem> data_dbList = new List<ListImageDbsResponse.ListImageDbs_Data.ListImageDbs_DbListItem>();
			for (int i = 0; i < context.Length("ListImageDbs.Data.DbList.Length"); i++) {
				ListImageDbsResponse.ListImageDbs_Data.ListImageDbs_DbListItem dbListItem = new ListImageDbsResponse.ListImageDbs_Data.ListImageDbs_DbListItem();
				dbListItem.Name = context.StringValue("ListImageDbs.Data.DbList["+ i +"].Name");

				data_dbList.Add(dbListItem);
			}
			data.DbList = data_dbList;
			listImageDbsResponse.Data = data;
        
			return listImageDbsResponse;
        }
    }
}
