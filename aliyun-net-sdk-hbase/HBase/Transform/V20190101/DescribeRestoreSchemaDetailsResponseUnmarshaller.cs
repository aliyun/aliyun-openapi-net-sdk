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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class DescribeRestoreSchemaDetailsResponseUnmarshaller
    {
        public static DescribeRestoreSchemaDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRestoreSchemaDetailsResponse describeRestoreSchemaDetailsResponse = new DescribeRestoreSchemaDetailsResponse();

			describeRestoreSchemaDetailsResponse.HttpResponse = _ctx.HttpResponse;
			describeRestoreSchemaDetailsResponse.RequestId = _ctx.StringValue("DescribeRestoreSchemaDetails.RequestId");

			DescribeRestoreSchemaDetailsResponse.DescribeRestoreSchemaDetails_RestoreSchema restoreSchema = new DescribeRestoreSchemaDetailsResponse.DescribeRestoreSchemaDetails_RestoreSchema();
			restoreSchema.Succeed = _ctx.IntegerValue("DescribeRestoreSchemaDetails.RestoreSchema.Succeed");
			restoreSchema.Fail = _ctx.IntegerValue("DescribeRestoreSchemaDetails.RestoreSchema.Fail");
			restoreSchema.Total = _ctx.LongValue("DescribeRestoreSchemaDetails.RestoreSchema.Total");
			restoreSchema.PageNumber = _ctx.IntegerValue("DescribeRestoreSchemaDetails.RestoreSchema.PageNumber");
			restoreSchema.PageSize = _ctx.IntegerValue("DescribeRestoreSchemaDetails.RestoreSchema.PageSize");

			List<DescribeRestoreSchemaDetailsResponse.DescribeRestoreSchemaDetails_RestoreSchema.DescribeRestoreSchemaDetails_RestoreSchemaDetail> restoreSchema_restoreSchemaDetails = new List<DescribeRestoreSchemaDetailsResponse.DescribeRestoreSchemaDetails_RestoreSchema.DescribeRestoreSchemaDetails_RestoreSchemaDetail>();
			for (int i = 0; i < _ctx.Length("DescribeRestoreSchemaDetails.RestoreSchema.RestoreSchemaDetails.Length"); i++) {
				DescribeRestoreSchemaDetailsResponse.DescribeRestoreSchemaDetails_RestoreSchema.DescribeRestoreSchemaDetails_RestoreSchemaDetail restoreSchemaDetail = new DescribeRestoreSchemaDetailsResponse.DescribeRestoreSchemaDetails_RestoreSchema.DescribeRestoreSchemaDetails_RestoreSchemaDetail();
				restoreSchemaDetail.Table = _ctx.StringValue("DescribeRestoreSchemaDetails.RestoreSchema.RestoreSchemaDetails["+ i +"].Table");
				restoreSchemaDetail.StartTime = _ctx.StringValue("DescribeRestoreSchemaDetails.RestoreSchema.RestoreSchemaDetails["+ i +"].StartTime");
				restoreSchemaDetail.EndTime = _ctx.StringValue("DescribeRestoreSchemaDetails.RestoreSchema.RestoreSchemaDetails["+ i +"].EndTime");
				restoreSchemaDetail.State = _ctx.StringValue("DescribeRestoreSchemaDetails.RestoreSchema.RestoreSchemaDetails["+ i +"].State");
				restoreSchemaDetail.Message = _ctx.StringValue("DescribeRestoreSchemaDetails.RestoreSchema.RestoreSchemaDetails["+ i +"].Message");

				restoreSchema_restoreSchemaDetails.Add(restoreSchemaDetail);
			}
			restoreSchema.RestoreSchemaDetails = restoreSchema_restoreSchemaDetails;
			describeRestoreSchemaDetailsResponse.RestoreSchema = restoreSchema;
        
			return describeRestoreSchemaDetailsResponse;
        }
    }
}
