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
using Aliyun.Acs.Kms.Model.V20160120;

namespace Aliyun.Acs.Kms.Transform.V20160120
{
    public class DescribeSecretResponseUnmarshaller
    {
        public static DescribeSecretResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSecretResponse describeSecretResponse = new DescribeSecretResponse();

			describeSecretResponse.HttpResponse = context.HttpResponse;
			describeSecretResponse.RequestId = context.StringValue("DescribeSecret.RequestId");
			describeSecretResponse.Arn = context.StringValue("DescribeSecret.Arn");
			describeSecretResponse.SecretName = context.StringValue("DescribeSecret.SecretName");
			describeSecretResponse.EncryptionKeyId = context.StringValue("DescribeSecret.EncryptionKeyId");
			describeSecretResponse.Description = context.StringValue("DescribeSecret.Description");
			describeSecretResponse.CreateTime = context.StringValue("DescribeSecret.CreateTime");
			describeSecretResponse.UpdateTime = context.StringValue("DescribeSecret.UpdateTime");
			describeSecretResponse.PlannedDeleteTime = context.StringValue("DescribeSecret.PlannedDeleteTime");

			List<DescribeSecretResponse.DescribeSecret_Tag> describeSecretResponse_tags = new List<DescribeSecretResponse.DescribeSecret_Tag>();
			for (int i = 0; i < context.Length("DescribeSecret.Tags.Length"); i++) {
				DescribeSecretResponse.DescribeSecret_Tag tag = new DescribeSecretResponse.DescribeSecret_Tag();
				tag.TagKey = context.StringValue("DescribeSecret.Tags["+ i +"].TagKey");
				tag.TagValue = context.StringValue("DescribeSecret.Tags["+ i +"].TagValue");

				describeSecretResponse_tags.Add(tag);
			}
			describeSecretResponse.Tags = describeSecretResponse_tags;
        
			return describeSecretResponse;
        }
    }
}
