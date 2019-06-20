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
using Aliyun.Acs.Airec.Model.V20181012;

namespace Aliyun.Acs.Airec.Transform.V20181012
{
    public class ListDataSourceResponseUnmarshaller
    {
        public static ListDataSourceResponse Unmarshall(UnmarshallerContext context)
        {
			ListDataSourceResponse listDataSourceResponse = new ListDataSourceResponse();

			listDataSourceResponse.HttpResponse = context.HttpResponse;
			listDataSourceResponse.RequestId = context.StringValue("ListDataSource.RequestId");
			listDataSourceResponse.Code = context.StringValue("ListDataSource.Code");
			listDataSourceResponse.Message = context.StringValue("ListDataSource.Message");

			List<ListDataSourceResponse.ListDataSource_ResultItem> listDataSourceResponse_result = new List<ListDataSourceResponse.ListDataSource_ResultItem>();
			for (int i = 0; i < context.Length("ListDataSource.Result.Length"); i++) {
				ListDataSourceResponse.ListDataSource_ResultItem resultItem = new ListDataSourceResponse.ListDataSource_ResultItem();
				resultItem.TableName = context.StringValue("ListDataSource.Result["+ i +"].TableName");
				resultItem.GmtCreate = context.StringValue("ListDataSource.Result["+ i +"].GmtCreate");
				resultItem.GmtModified = context.StringValue("ListDataSource.Result["+ i +"].GmtModified");

				ListDataSourceResponse.ListDataSource_ResultItem.ListDataSource_Meta meta = new ListDataSourceResponse.ListDataSource_ResultItem.ListDataSource_Meta();
				meta.AccessKeyId = context.StringValue("ListDataSource.Result["+ i +"].Meta.AccessKeyId");
				meta.ProjectName = context.StringValue("ListDataSource.Result["+ i +"].Meta.ProjectName");
				meta.TableName = context.StringValue("ListDataSource.Result["+ i +"].Meta.TableName");
				meta.Partition = context.StringValue("ListDataSource.Result["+ i +"].Meta.Partition");
				meta.Timestamp = context.LongValue("ListDataSource.Result["+ i +"].Meta.Timestamp");
				meta.BucketName = context.StringValue("ListDataSource.Result["+ i +"].Meta.BucketName");
				meta.Path = context.StringValue("ListDataSource.Result["+ i +"].Meta.Path");
				meta.Type = context.StringValue("ListDataSource.Result["+ i +"].Meta.Type");
				resultItem.Meta = meta;

				listDataSourceResponse_result.Add(resultItem);
			}
			listDataSourceResponse.Result = listDataSourceResponse_result;
        
			return listDataSourceResponse;
        }
    }
}
