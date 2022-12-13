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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class ValidateDataSourcesResponseUnmarshaller
    {
        public static ValidateDataSourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ValidateDataSourcesResponse validateDataSourcesResponse = new ValidateDataSourcesResponse();

			validateDataSourcesResponse.HttpResponse = _ctx.HttpResponse;
			validateDataSourcesResponse.RequestId = _ctx.StringValue("ValidateDataSources.requestId");

			List<ValidateDataSourcesResponse.ValidateDataSources_ResultItem> validateDataSourcesResponse_result = new List<ValidateDataSourcesResponse.ValidateDataSources_ResultItem>();
			for (int i = 0; i < _ctx.Length("ValidateDataSources.Result.Length"); i++) {
				ValidateDataSourcesResponse.ValidateDataSources_ResultItem resultItem = new ValidateDataSourcesResponse.ValidateDataSources_ResultItem();
				resultItem.Code = _ctx.StringValue("ValidateDataSources.Result["+ i +"].code");
				resultItem.Message = _ctx.StringValue("ValidateDataSources.Result["+ i +"].message");

				ValidateDataSourcesResponse.ValidateDataSources_ResultItem.ValidateDataSources_DataSource dataSource = new ValidateDataSourcesResponse.ValidateDataSources_ResultItem.ValidateDataSources_DataSource();
				dataSource.TableName = _ctx.StringValue("ValidateDataSources.Result["+ i +"].DataSource.tableName");
				dataSource.Type = _ctx.StringValue("ValidateDataSources.Result["+ i +"].DataSource.type");
				dataSource.Parameters = _ctx.StringValue("ValidateDataSources.Result["+ i +"].DataSource.parameters");
				resultItem.DataSource = dataSource;

				validateDataSourcesResponse_result.Add(resultItem);
			}
			validateDataSourcesResponse.Result = validateDataSourcesResponse_result;
        
			return validateDataSourcesResponse;
        }
    }
}
