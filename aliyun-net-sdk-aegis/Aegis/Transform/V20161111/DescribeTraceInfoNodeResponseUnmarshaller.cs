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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeTraceInfoNodeResponseUnmarshaller
    {
        public static DescribeTraceInfoNodeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTraceInfoNodeResponse describeTraceInfoNodeResponse = new DescribeTraceInfoNodeResponse();

			describeTraceInfoNodeResponse.HttpResponse = context.HttpResponse;
			describeTraceInfoNodeResponse.RequestId = context.StringValue("DescribeTraceInfoNode.RequestId");

			DescribeTraceInfoNodeResponse.DescribeTraceInfoNode_Node node = new DescribeTraceInfoNodeResponse.DescribeTraceInfoNode_Node();
			node.Name = context.StringValue("DescribeTraceInfoNode.Node.Name");
			node.Type = context.StringValue("DescribeTraceInfoNode.Node.Type");

			List<DescribeTraceInfoNodeResponse.DescribeTraceInfoNode_Node.DescribeTraceInfoNode_Property> node_propertyList = new List<DescribeTraceInfoNodeResponse.DescribeTraceInfoNode_Node.DescribeTraceInfoNode_Property>();
			for (int i = 0; i < context.Length("DescribeTraceInfoNode.Node.PropertyList.Length"); i++) {
				DescribeTraceInfoNodeResponse.DescribeTraceInfoNode_Node.DescribeTraceInfoNode_Property property = new DescribeTraceInfoNodeResponse.DescribeTraceInfoNode_Node.DescribeTraceInfoNode_Property();
				property.Name = context.StringValue("DescribeTraceInfoNode.Node.PropertyList["+ i +"].Name");
				property._Value = context.StringValue("DescribeTraceInfoNode.Node.PropertyList["+ i +"].Value");

				node_propertyList.Add(property);
			}
			node.PropertyList = node_propertyList;
			describeTraceInfoNodeResponse.Node = node;
        
			return describeTraceInfoNodeResponse;
        }
    }
}
