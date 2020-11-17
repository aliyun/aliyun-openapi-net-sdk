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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListExtendfilesResponseUnmarshaller
    {
        public static ListExtendfilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListExtendfilesResponse listExtendfilesResponse = new ListExtendfilesResponse();

			listExtendfilesResponse.HttpResponse = _ctx.HttpResponse;
			listExtendfilesResponse.RequestId = _ctx.StringValue("ListExtendfiles.RequestId");

			List<ListExtendfilesResponse.ListExtendfiles_ResultItem> listExtendfilesResponse_result = new List<ListExtendfilesResponse.ListExtendfiles_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListExtendfiles.Result.Length"); i++) {
				ListExtendfilesResponse.ListExtendfiles_ResultItem resultItem = new ListExtendfilesResponse.ListExtendfiles_ResultItem();
				resultItem.Name = _ctx.StringValue("ListExtendfiles.Result["+ i +"].name");
				resultItem.FileSize = _ctx.LongValue("ListExtendfiles.Result["+ i +"].fileSize");
				resultItem.SourceType = _ctx.StringValue("ListExtendfiles.Result["+ i +"].sourceType");
				resultItem.FilePath = _ctx.StringValue("ListExtendfiles.Result["+ i +"].filePath");

				listExtendfilesResponse_result.Add(resultItem);
			}
			listExtendfilesResponse.Result = listExtendfilesResponse_result;
        
			return listExtendfilesResponse;
        }
    }
}
