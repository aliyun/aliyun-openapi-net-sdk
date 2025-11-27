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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class DescribeLatestRecordSchemaResponseUnmarshaller
    {
        public static DescribeLatestRecordSchemaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLatestRecordSchemaResponse describeLatestRecordSchemaResponse = new DescribeLatestRecordSchemaResponse();

			describeLatestRecordSchemaResponse.HttpResponse = _ctx.HttpResponse;
			describeLatestRecordSchemaResponse.RequestId = _ctx.StringValue("DescribeLatestRecordSchema.RequestId");

			DescribeLatestRecordSchemaResponse.DescribeLatestRecordSchema_PlaybookNodeSchema playbookNodeSchema = new DescribeLatestRecordSchemaResponse.DescribeLatestRecordSchema_PlaybookNodeSchema();
			playbookNodeSchema.IsFinished = _ctx.BooleanValue("DescribeLatestRecordSchema.PlaybookNodeSchema.IsFinished");

			List<DescribeLatestRecordSchemaResponse.DescribeLatestRecordSchema_PlaybookNodeSchema.DescribeLatestRecordSchema_NodeSchemaItem> playbookNodeSchema_nodeSchema = new List<DescribeLatestRecordSchemaResponse.DescribeLatestRecordSchema_PlaybookNodeSchema.DescribeLatestRecordSchema_NodeSchemaItem>();
			for (int i = 0; i < _ctx.Length("DescribeLatestRecordSchema.PlaybookNodeSchema.NodeSchema.Length"); i++) {
				DescribeLatestRecordSchemaResponse.DescribeLatestRecordSchema_PlaybookNodeSchema.DescribeLatestRecordSchema_NodeSchemaItem nodeSchemaItem = new DescribeLatestRecordSchemaResponse.DescribeLatestRecordSchema_PlaybookNodeSchema.DescribeLatestRecordSchema_NodeSchemaItem();
				nodeSchemaItem.NodeName = _ctx.StringValue("DescribeLatestRecordSchema.PlaybookNodeSchema.NodeSchema["+ i +"].NodeName");
				nodeSchemaItem.ComponentName = _ctx.StringValue("DescribeLatestRecordSchema.PlaybookNodeSchema.NodeSchema["+ i +"].ComponentName");
				nodeSchemaItem.ActionName = _ctx.StringValue("DescribeLatestRecordSchema.PlaybookNodeSchema.NodeSchema["+ i +"].ActionName");

				List<string> nodeSchemaItem_outputFields = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeLatestRecordSchema.PlaybookNodeSchema.NodeSchema["+ i +"].OutputFields.Length"); j++) {
					nodeSchemaItem_outputFields.Add(_ctx.StringValue("DescribeLatestRecordSchema.PlaybookNodeSchema.NodeSchema["+ i +"].OutputFields["+ j +"]"));
				}
				nodeSchemaItem.OutputFields = nodeSchemaItem_outputFields;

				playbookNodeSchema_nodeSchema.Add(nodeSchemaItem);
			}
			playbookNodeSchema.NodeSchema = playbookNodeSchema_nodeSchema;
			describeLatestRecordSchemaResponse.PlaybookNodeSchema = playbookNodeSchema;
        
			return describeLatestRecordSchemaResponse;
        }
    }
}
