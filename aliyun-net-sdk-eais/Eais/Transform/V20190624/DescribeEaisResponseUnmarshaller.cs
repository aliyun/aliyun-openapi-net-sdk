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
using Aliyun.Acs.eais.Model.V20190624;

namespace Aliyun.Acs.eais.Transform.V20190624
{
    public class DescribeEaisResponseUnmarshaller
    {
        public static DescribeEaisResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEaisResponse describeEaisResponse = new DescribeEaisResponse();

			describeEaisResponse.HttpResponse = _ctx.HttpResponse;
			describeEaisResponse.PageNumber = _ctx.IntegerValue("DescribeEais.PageNumber");
			describeEaisResponse.TotalCount = _ctx.IntegerValue("DescribeEais.TotalCount");
			describeEaisResponse.PageSize = _ctx.IntegerValue("DescribeEais.PageSize");
			describeEaisResponse.RequestId = _ctx.StringValue("DescribeEais.RequestId");

			List<DescribeEaisResponse.DescribeEais_Instance> describeEaisResponse_instances = new List<DescribeEaisResponse.DescribeEais_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeEais.Instances.Length"); i++) {
				DescribeEaisResponse.DescribeEais_Instance instance = new DescribeEaisResponse.DescribeEais_Instance();
				instance.RegionId = _ctx.StringValue("DescribeEais.Instances["+ i +"].RegionId");
				instance.ZoneId = _ctx.StringValue("DescribeEais.Instances["+ i +"].ZoneId");
				instance.CreationTime = _ctx.StringValue("DescribeEais.Instances["+ i +"].CreationTime");
				instance.InstanceName = _ctx.StringValue("DescribeEais.Instances["+ i +"].InstanceName");
				instance.Description = _ctx.StringValue("DescribeEais.Instances["+ i +"].Description");
				instance.Status = _ctx.StringValue("DescribeEais.Instances["+ i +"].Status");
				instance.ElasticAcceleratedInstanceId = _ctx.StringValue("DescribeEais.Instances["+ i +"].ElasticAcceleratedInstanceId");
				instance.ClientInstanceId = _ctx.StringValue("DescribeEais.Instances["+ i +"].ClientInstanceId");
				instance.InstanceType = _ctx.StringValue("DescribeEais.Instances["+ i +"].InstanceType");
				instance.ClientInstanceType = _ctx.StringValue("DescribeEais.Instances["+ i +"].ClientInstanceType");
				instance.ClientInstanceName = _ctx.StringValue("DescribeEais.Instances["+ i +"].ClientInstanceName");

				List<DescribeEaisResponse.DescribeEais_Instance.DescribeEais_Tag> instance_tags = new List<DescribeEaisResponse.DescribeEais_Instance.DescribeEais_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeEais.Instances["+ i +"].Tags.Length"); j++) {
					DescribeEaisResponse.DescribeEais_Instance.DescribeEais_Tag tag = new DescribeEaisResponse.DescribeEais_Instance.DescribeEais_Tag();
					tag.TagValue = _ctx.StringValue("DescribeEais.Instances["+ i +"].Tags["+ j +"].TagValue");
					tag.TagKey = _ctx.StringValue("DescribeEais.Instances["+ i +"].Tags["+ j +"].TagKey");

					instance_tags.Add(tag);
				}
				instance.Tags = instance_tags;

				describeEaisResponse_instances.Add(instance);
			}
			describeEaisResponse.Instances = describeEaisResponse_instances;
        
			return describeEaisResponse;
        }
    }
}
