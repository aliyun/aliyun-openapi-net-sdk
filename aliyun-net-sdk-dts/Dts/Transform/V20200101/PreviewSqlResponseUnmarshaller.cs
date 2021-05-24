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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class PreviewSqlResponseUnmarshaller
    {
        public static PreviewSqlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PreviewSqlResponse previewSqlResponse = new PreviewSqlResponse();

			previewSqlResponse.HttpResponse = _ctx.HttpResponse;
			previewSqlResponse.DynamicCode = _ctx.StringValue("PreviewSql.DynamicCode");
			previewSqlResponse.DynamicMessage = _ctx.StringValue("PreviewSql.DynamicMessage");
			previewSqlResponse.ErrCode = _ctx.StringValue("PreviewSql.ErrCode");
			previewSqlResponse.ErrMessage = _ctx.StringValue("PreviewSql.ErrMessage");
			previewSqlResponse.HttpStatusCode = _ctx.IntegerValue("PreviewSql.HttpStatusCode");
			previewSqlResponse.RequestId = _ctx.StringValue("PreviewSql.RequestId");
			previewSqlResponse.Success = _ctx.BooleanValue("PreviewSql.Success");
			previewSqlResponse.StreamGraph = _ctx.StringValue("PreviewSql.StreamGraph");
			previewSqlResponse.ValidationException = _ctx.StringValue("PreviewSql.ValidationException");

			List<string> previewSqlResponse_sqlList = new List<string>();
			for (int i = 0; i < _ctx.Length("PreviewSql.SqlList.Length"); i++) {
				previewSqlResponse_sqlList.Add(_ctx.StringValue("PreviewSql.SqlList["+ i +"]"));
			}
			previewSqlResponse.SqlList = previewSqlResponse_sqlList;
        
			return previewSqlResponse;
        }
    }
}
