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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeSecretsResponseUnmarshaller
    {
        public static DescribeSecretsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSecretsResponse describeSecretsResponse = new DescribeSecretsResponse();

			describeSecretsResponse.HttpResponse = _ctx.HttpResponse;
			describeSecretsResponse.RequestId = _ctx.StringValue("DescribeSecrets.RequestId");
			describeSecretsResponse.PageSize = _ctx.LongValue("DescribeSecrets.PageSize");
			describeSecretsResponse.PageNumber = _ctx.LongValue("DescribeSecrets.PageNumber");

			List<DescribeSecretsResponse.DescribeSecrets_SecretsItem> describeSecretsResponse_secrets = new List<DescribeSecretsResponse.DescribeSecrets_SecretsItem>();
			for (int i = 0; i < _ctx.Length("DescribeSecrets.Secrets.Length"); i++) {
				DescribeSecretsResponse.DescribeSecrets_SecretsItem secretsItem = new DescribeSecretsResponse.DescribeSecrets_SecretsItem();
				secretsItem.AccountId = _ctx.StringValue("DescribeSecrets.Secrets["+ i +"].AccountId");
				secretsItem.SecretName = _ctx.StringValue("DescribeSecrets.Secrets["+ i +"].SecretName");
				secretsItem.RegionId = _ctx.StringValue("DescribeSecrets.Secrets["+ i +"].RegionId");
				secretsItem.SecretArn = _ctx.StringValue("DescribeSecrets.Secrets["+ i +"].SecretArn");
				secretsItem.Description = _ctx.StringValue("DescribeSecrets.Secrets["+ i +"].Description");
				secretsItem.Username = _ctx.StringValue("DescribeSecrets.Secrets["+ i +"].Username");

				describeSecretsResponse_secrets.Add(secretsItem);
			}
			describeSecretsResponse.Secrets = describeSecretsResponse_secrets;
        
			return describeSecretsResponse;
        }
    }
}
