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
    public class DescribeDataSourceResponseUnmarshaller
    {
        public static DescribeDataSourceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataSourceResponse describeDataSourceResponse = new DescribeDataSourceResponse();

			describeDataSourceResponse.HttpResponse = context.HttpResponse;
			describeDataSourceResponse.RequestId = context.StringValue("DescribeDataSource.RequestId");
			describeDataSourceResponse.Success = context.BooleanValue("DescribeDataSource.Success");
			describeDataSourceResponse.Count = context.IntegerValue("DescribeDataSource.Count");

			List<DescribeDataSourceResponse.DescribeDataSource_Data> describeDataSourceResponse_metaDatas = new List<DescribeDataSourceResponse.DescribeDataSource_Data>();
			for (int i = 0; i < context.Length("DescribeDataSource.MetaDatas.Length"); i++) {
				DescribeDataSourceResponse.DescribeDataSource_Data data = new DescribeDataSourceResponse.DescribeDataSource_Data();
				data.DataSourceId = context.IntegerValue("DescribeDataSource.MetaDatas["+ i +"].DataSourceId");
				data.DateSourceName = context.StringValue("DescribeDataSource.MetaDatas["+ i +"].DateSourceName");
				data.Description = context.StringValue("DescribeDataSource.MetaDatas["+ i +"].Description");

				List<DescribeDataSourceResponse.DescribeDataSource_Data.DescribeDataSource_MetaDataField> data_metaDataFields = new List<DescribeDataSourceResponse.DescribeDataSource_Data.DescribeDataSource_MetaDataField>();
				for (int j = 0; j < context.Length("DescribeDataSource.MetaDatas["+ i +"].MetaDataFields.Length"); j++) {
					DescribeDataSourceResponse.DescribeDataSource_Data.DescribeDataSource_MetaDataField metaDataField = new DescribeDataSourceResponse.DescribeDataSource_Data.DescribeDataSource_MetaDataField();
					metaDataField.FiledName = context.StringValue("DescribeDataSource.MetaDatas["+ i +"].MetaDataFields["+ j +"].FiledName");
					metaDataField.Filed = context.StringValue("DescribeDataSource.MetaDatas["+ i +"].MetaDataFields["+ j +"].Filed");
					metaDataField.ValueType = context.StringValue("DescribeDataSource.MetaDatas["+ i +"].MetaDataFields["+ j +"].ValueType");
					metaDataField.Sample = context.StringValue("DescribeDataSource.MetaDatas["+ i +"].MetaDataFields["+ j +"].Sample");

					List<DescribeDataSourceResponse.DescribeDataSource_Data.DescribeDataSource_MetaDataField.DescribeDataSource__Operator> metaDataField_operatorList = new List<DescribeDataSourceResponse.DescribeDataSource_Data.DescribeDataSource_MetaDataField.DescribeDataSource__Operator>();
					for (int k = 0; k < context.Length("DescribeDataSource.MetaDatas["+ i +"].MetaDataFields["+ j +"].OperatorList.Length"); k++) {
						DescribeDataSourceResponse.DescribeDataSource_Data.DescribeDataSource_MetaDataField.DescribeDataSource__Operator _operator = new DescribeDataSourceResponse.DescribeDataSource_Data.DescribeDataSource_MetaDataField.DescribeDataSource__Operator();
						_operator.Name = context.StringValue("DescribeDataSource.MetaDatas["+ i +"].MetaDataFields["+ j +"].OperatorList["+ k +"].Name");
						_operator.Description = context.StringValue("DescribeDataSource.MetaDatas["+ i +"].MetaDataFields["+ j +"].OperatorList["+ k +"].Description");

						metaDataField_operatorList.Add(_operator);
					}
					metaDataField.OperatorList = metaDataField_operatorList;

					data_metaDataFields.Add(metaDataField);
				}
				data.MetaDataFields = data_metaDataFields;

				describeDataSourceResponse_metaDatas.Add(data);
			}
			describeDataSourceResponse.MetaDatas = describeDataSourceResponse_metaDatas;
        
			return describeDataSourceResponse;
        }
    }
}
