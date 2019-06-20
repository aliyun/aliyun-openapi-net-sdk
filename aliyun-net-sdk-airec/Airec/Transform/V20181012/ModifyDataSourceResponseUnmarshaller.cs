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
    public class ModifyDataSourceResponseUnmarshaller
    {
        public static ModifyDataSourceResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyDataSourceResponse modifyDataSourceResponse = new ModifyDataSourceResponse();

			modifyDataSourceResponse.HttpResponse = context.HttpResponse;
			modifyDataSourceResponse.RequestId = context.StringValue("ModifyDataSource.RequestId");
			modifyDataSourceResponse.Code = context.StringValue("ModifyDataSource.Code");
			modifyDataSourceResponse.Message = context.StringValue("ModifyDataSource.Message");

			ModifyDataSourceResponse.ModifyDataSource_Result result = new ModifyDataSourceResponse.ModifyDataSource_Result();
			result.TableName = context.StringValue("ModifyDataSource.Result.TableName");
			result.GmtCreate = context.StringValue("ModifyDataSource.Result.GmtCreate");
			result.GmtModified = context.StringValue("ModifyDataSource.Result.GmtModified");

			ModifyDataSourceResponse.ModifyDataSource_Result.ModifyDataSource_Meta meta = new ModifyDataSourceResponse.ModifyDataSource_Result.ModifyDataSource_Meta();
			meta.AccessKeyId = context.StringValue("ModifyDataSource.Result.Meta.AccessKeyId");
			meta.ProjectName = context.StringValue("ModifyDataSource.Result.Meta.ProjectName");
			meta.TableName = context.StringValue("ModifyDataSource.Result.Meta.TableName");
			meta.Partition = context.StringValue("ModifyDataSource.Result.Meta.Partition");
			meta.Timestamp = context.LongValue("ModifyDataSource.Result.Meta.Timestamp");
			meta.BucketName = context.StringValue("ModifyDataSource.Result.Meta.BucketName");
			meta.Path = context.StringValue("ModifyDataSource.Result.Meta.Path");
			meta.Type = context.StringValue("ModifyDataSource.Result.Meta.Type");
			result.Meta = meta;
			modifyDataSourceResponse.Result = result;
        
			return modifyDataSourceResponse;
        }
    }
}
