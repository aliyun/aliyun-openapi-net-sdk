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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeLogicDBInstanceTopologyResponseUnmarshaller
    {
        public static DescribeLogicDBInstanceTopologyResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLogicDBInstanceTopologyResponse describeLogicDBInstanceTopologyResponse = new DescribeLogicDBInstanceTopologyResponse();

			describeLogicDBInstanceTopologyResponse.HttpResponse = context.HttpResponse;
			describeLogicDBInstanceTopologyResponse.DBInstanceId = context.IntegerValue("DescribeLogicDBInstanceTopology.DBInstanceId");
			describeLogicDBInstanceTopologyResponse.DBInstanceName = context.StringValue("DescribeLogicDBInstanceTopology.DBInstanceName");
			describeLogicDBInstanceTopologyResponse.DBInstanceStatus = context.IntegerValue("DescribeLogicDBInstanceTopology.DBInstanceStatus");
			describeLogicDBInstanceTopologyResponse.DBInstanceStatusDesc = context.StringValue("DescribeLogicDBInstanceTopology.DBInstanceStatusDesc");
			describeLogicDBInstanceTopologyResponse.DBInstanceConnType = context.StringValue("DescribeLogicDBInstanceTopology.DBInstanceConnType");
			describeLogicDBInstanceTopologyResponse.DBInstanceDescription = context.StringValue("DescribeLogicDBInstanceTopology.DBInstanceDescription");
			describeLogicDBInstanceTopologyResponse.Engine = context.StringValue("DescribeLogicDBInstanceTopology.Engine");
			describeLogicDBInstanceTopologyResponse.EngineVersion = context.StringValue("DescribeLogicDBInstanceTopology.EngineVersion");

			List<DescribeLogicDBInstanceTopologyResponse.DescribeLogicDBInstanceTopology_LogicDBInstanceParameter> describeLogicDBInstanceTopologyResponse_items = new List<DescribeLogicDBInstanceTopologyResponse.DescribeLogicDBInstanceTopology_LogicDBInstanceParameter>();
			for (int i = 0; i < context.Length("DescribeLogicDBInstanceTopology.Items.Length"); i++) {
				DescribeLogicDBInstanceTopologyResponse.DescribeLogicDBInstanceTopology_LogicDBInstanceParameter logicDBInstanceParameter = new DescribeLogicDBInstanceTopologyResponse.DescribeLogicDBInstanceTopology_LogicDBInstanceParameter();
				logicDBInstanceParameter.DBInstanceID = context.IntegerValue("DescribeLogicDBInstanceTopology.Items["+ i +"].DBInstanceID");
				logicDBInstanceParameter.DBInstanceName = context.StringValue("DescribeLogicDBInstanceTopology.Items["+ i +"].DBInstanceName");
				logicDBInstanceParameter.DBInstanceStatus = context.IntegerValue("DescribeLogicDBInstanceTopology.Items["+ i +"].DBInstanceStatus");
				logicDBInstanceParameter.DBInstanceStatusDesc = context.StringValue("DescribeLogicDBInstanceTopology.Items["+ i +"].DBInstanceStatusDesc");
				logicDBInstanceParameter.DBInstanceConnType = context.StringValue("DescribeLogicDBInstanceTopology.Items["+ i +"].DBInstanceConnType");
				logicDBInstanceParameter.DBInstanceDescription = context.StringValue("DescribeLogicDBInstanceTopology.Items["+ i +"].DBInstanceDescription");
				logicDBInstanceParameter.Engine = context.StringValue("DescribeLogicDBInstanceTopology.Items["+ i +"].Engine");
				logicDBInstanceParameter.EngineVersion = context.StringValue("DescribeLogicDBInstanceTopology.Items["+ i +"].EngineVersion");
				logicDBInstanceParameter.CharacterType = context.StringValue("DescribeLogicDBInstanceTopology.Items["+ i +"].CharacterType");

				describeLogicDBInstanceTopologyResponse_items.Add(logicDBInstanceParameter);
			}
			describeLogicDBInstanceTopologyResponse.Items = describeLogicDBInstanceTopologyResponse_items;
        
			return describeLogicDBInstanceTopologyResponse;
        }
    }
}