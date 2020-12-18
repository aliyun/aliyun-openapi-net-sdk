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
        public static DescribeSecretResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSecretResponse describeSecretResponse = new DescribeSecretResponse();

			describeSecretResponse.HttpResponse = _ctx.HttpResponse;
			describeSecretResponse.RequestId = _ctx.StringValue("DescribeSecret.RequestId");
			describeSecretResponse.Arn = _ctx.StringValue("DescribeSecret.Arn");
			describeSecretResponse.SecretName = _ctx.StringValue("DescribeSecret.SecretName");
			describeSecretResponse.EncryptionKeyId = _ctx.StringValue("DescribeSecret.EncryptionKeyId");
			describeSecretResponse.Description = _ctx.StringValue("DescribeSecret.Description");
			describeSecretResponse.CreateTime = _ctx.StringValue("DescribeSecret.CreateTime");
			describeSecretResponse.UpdateTime = _ctx.StringValue("DescribeSecret.UpdateTime");
			describeSecretResponse.PlannedDeleteTime = _ctx.StringValue("DescribeSecret.PlannedDeleteTime");
			describeSecretResponse.AutomaticRotation = _ctx.StringValue("DescribeSecret.AutomaticRotation");
			describeSecretResponse.LastRotationDate = _ctx.StringValue("DescribeSecret.LastRotationDate");
			describeSecretResponse.RotationInterval = _ctx.StringValue("DescribeSecret.RotationInterval");
			describeSecretResponse.NextRotationDate = _ctx.StringValue("DescribeSecret.NextRotationDate");
			describeSecretResponse.ExtendedConfig = _ctx.StringValue("DescribeSecret.ExtendedConfig");
			describeSecretResponse.SecretType = _ctx.StringValue("DescribeSecret.SecretType");

			List<DescribeSecretResponse.DescribeSecret_Tag> describeSecretResponse_tags = new List<DescribeSecretResponse.DescribeSecret_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeSecret.Tags.Length"); i++) {
				DescribeSecretResponse.DescribeSecret_Tag tag = new DescribeSecretResponse.DescribeSecret_Tag();
				tag.TagKey = _ctx.StringValue("DescribeSecret.Tags["+ i +"].TagKey");
				tag.TagValue = _ctx.StringValue("DescribeSecret.Tags["+ i +"].TagValue");

				describeSecretResponse_tags.Add(tag);
			}
			describeSecretResponse.Tags = describeSecretResponse_tags;
        
			return describeSecretResponse;
        }
    }
}
