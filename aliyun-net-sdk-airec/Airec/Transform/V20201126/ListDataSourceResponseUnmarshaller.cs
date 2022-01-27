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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class ListDataSourceResponseUnmarshaller
    {
        public static ListDataSourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataSourceResponse listDataSourceResponse = new ListDataSourceResponse();

			listDataSourceResponse.HttpResponse = _ctx.HttpResponse;
			listDataSourceResponse.Code = _ctx.StringValue("ListDataSource.code");
			listDataSourceResponse.Message = _ctx.StringValue("ListDataSource.message");
			listDataSourceResponse.RequestId = _ctx.StringValue("ListDataSource.requestId");

			List<ListDataSourceResponse.ListDataSource_ResultItem> listDataSourceResponse_result = new List<ListDataSourceResponse.ListDataSource_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListDataSource.Result.Length"); i++) {
				ListDataSourceResponse.ListDataSource_ResultItem resultItem = new ListDataSourceResponse.ListDataSource_ResultItem();
				resultItem.GmtCreate = _ctx.StringValue("ListDataSource.Result["+ i +"].gmtCreate");
				resultItem.GmtModified = _ctx.StringValue("ListDataSource.Result["+ i +"].gmtModified");
				resultItem.TableName = _ctx.StringValue("ListDataSource.Result["+ i +"].tableName");

				ListDataSourceResponse.ListDataSource_ResultItem.ListDataSource_Meta meta = new ListDataSourceResponse.ListDataSource_ResultItem.ListDataSource_Meta();
				meta.AccessKeyId = _ctx.StringValue("ListDataSource.Result["+ i +"].Meta.accessKeyId");
				meta.BucketName = _ctx.StringValue("ListDataSource.Result["+ i +"].Meta.bucketName");
				meta.Partition = _ctx.StringValue("ListDataSource.Result["+ i +"].Meta.partition");
				meta.Path = _ctx.StringValue("ListDataSource.Result["+ i +"].Meta.path");
				meta.ProjectName = _ctx.StringValue("ListDataSource.Result["+ i +"].Meta.projectName");
				meta.TableName = _ctx.StringValue("ListDataSource.Result["+ i +"].Meta.tableName");
				meta.Timestamp = _ctx.LongValue("ListDataSource.Result["+ i +"].Meta.timestamp");
				meta.Type = _ctx.StringValue("ListDataSource.Result["+ i +"].Meta.type");
				resultItem.Meta = meta;

				listDataSourceResponse_result.Add(resultItem);
			}
			listDataSourceResponse.Result = listDataSourceResponse_result;
        
			return listDataSourceResponse;
        }
    }
}
