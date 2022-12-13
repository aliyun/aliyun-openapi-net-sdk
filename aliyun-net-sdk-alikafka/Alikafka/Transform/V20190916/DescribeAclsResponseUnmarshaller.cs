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
using Aliyun.Acs.alikafka.Model.V20190916;

namespace Aliyun.Acs.alikafka.Transform.V20190916
{
    public class DescribeAclsResponseUnmarshaller
    {
        public static DescribeAclsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAclsResponse describeAclsResponse = new DescribeAclsResponse();

			describeAclsResponse.HttpResponse = _ctx.HttpResponse;
			describeAclsResponse.Code = _ctx.IntegerValue("DescribeAcls.Code");
			describeAclsResponse.Message = _ctx.StringValue("DescribeAcls.Message");
			describeAclsResponse.RequestId = _ctx.StringValue("DescribeAcls.RequestId");
			describeAclsResponse.Success = _ctx.BooleanValue("DescribeAcls.Success");

			List<DescribeAclsResponse.DescribeAcls_KafkaAclVO> describeAclsResponse_kafkaAclList = new List<DescribeAclsResponse.DescribeAcls_KafkaAclVO>();
			for (int i = 0; i < _ctx.Length("DescribeAcls.KafkaAclList.Length"); i++) {
				DescribeAclsResponse.DescribeAcls_KafkaAclVO kafkaAclVO = new DescribeAclsResponse.DescribeAcls_KafkaAclVO();
				kafkaAclVO.AclResourceType = _ctx.StringValue("DescribeAcls.KafkaAclList["+ i +"].AclResourceType");
				kafkaAclVO.Host = _ctx.StringValue("DescribeAcls.KafkaAclList["+ i +"].Host");
				kafkaAclVO.AclOperationType = _ctx.StringValue("DescribeAcls.KafkaAclList["+ i +"].AclOperationType");
				kafkaAclVO.AclResourceName = _ctx.StringValue("DescribeAcls.KafkaAclList["+ i +"].AclResourceName");
				kafkaAclVO.AclResourcePatternType = _ctx.StringValue("DescribeAcls.KafkaAclList["+ i +"].AclResourcePatternType");
				kafkaAclVO.Username = _ctx.StringValue("DescribeAcls.KafkaAclList["+ i +"].Username");

				describeAclsResponse_kafkaAclList.Add(kafkaAclVO);
			}
			describeAclsResponse.KafkaAclList = describeAclsResponse_kafkaAclList;
        
			return describeAclsResponse;
        }
    }
}
