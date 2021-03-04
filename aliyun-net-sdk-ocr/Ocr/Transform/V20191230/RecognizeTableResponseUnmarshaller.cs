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
using Aliyun.Acs.ocr.Model.V20191230;

namespace Aliyun.Acs.ocr.Transform.V20191230
{
    public class RecognizeTableResponseUnmarshaller
    {
        public static RecognizeTableResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeTableResponse recognizeTableResponse = new RecognizeTableResponse();

			recognizeTableResponse.HttpResponse = _ctx.HttpResponse;
			recognizeTableResponse.RequestId = _ctx.StringValue("RecognizeTable.RequestId");

			RecognizeTableResponse.RecognizeTable_Data data = new RecognizeTableResponse.RecognizeTable_Data();
			data.FileContent = _ctx.StringValue("RecognizeTable.Data.FileContent");

			List<RecognizeTableResponse.RecognizeTable_Data.RecognizeTable_Table> data_tables = new List<RecognizeTableResponse.RecognizeTable_Data.RecognizeTable_Table>();
			for (int i = 0; i < _ctx.Length("RecognizeTable.Data.Tables.Length"); i++) {
				RecognizeTableResponse.RecognizeTable_Data.RecognizeTable_Table table = new RecognizeTableResponse.RecognizeTable_Data.RecognizeTable_Table();

				List<string> table_head = new List<string>();
				for (int j = 0; j < _ctx.Length("RecognizeTable.Data.Tables["+ i +"].Head.Length"); j++) {
					table_head.Add(_ctx.StringValue("RecognizeTable.Data.Tables["+ i +"].Head["+ j +"]"));
				}
				table.Head = table_head;

				List<string> table_tail = new List<string>();
				for (int j = 0; j < _ctx.Length("RecognizeTable.Data.Tables["+ i +"].Tail.Length"); j++) {
					table_tail.Add(_ctx.StringValue("RecognizeTable.Data.Tables["+ i +"].Tail["+ j +"]"));
				}
				table.Tail = table_tail;

				List<RecognizeTableResponse.RecognizeTable_Data.RecognizeTable_Table.RecognizeTable_TableRow> table_tableRows = new List<RecognizeTableResponse.RecognizeTable_Data.RecognizeTable_Table.RecognizeTable_TableRow>();
				for (int j = 0; j < _ctx.Length("RecognizeTable.Data.Tables["+ i +"].TableRows.Length"); j++) {
					RecognizeTableResponse.RecognizeTable_Data.RecognizeTable_Table.RecognizeTable_TableRow tableRow = new RecognizeTableResponse.RecognizeTable_Data.RecognizeTable_Table.RecognizeTable_TableRow();

					List<RecognizeTableResponse.RecognizeTable_Data.RecognizeTable_Table.RecognizeTable_TableRow.RecognizeTable_TableColumn> tableRow_tableColumns = new List<RecognizeTableResponse.RecognizeTable_Data.RecognizeTable_Table.RecognizeTable_TableRow.RecognizeTable_TableColumn>();
					for (int k = 0; k < _ctx.Length("RecognizeTable.Data.Tables["+ i +"].TableRows["+ j +"].TableColumns.Length"); k++) {
						RecognizeTableResponse.RecognizeTable_Data.RecognizeTable_Table.RecognizeTable_TableRow.RecognizeTable_TableColumn tableColumn = new RecognizeTableResponse.RecognizeTable_Data.RecognizeTable_Table.RecognizeTable_TableRow.RecognizeTable_TableColumn();
						tableColumn.StartColumn = _ctx.IntegerValue("RecognizeTable.Data.Tables["+ i +"].TableRows["+ j +"].TableColumns["+ k +"].StartColumn");
						tableColumn.StartRow = _ctx.IntegerValue("RecognizeTable.Data.Tables["+ i +"].TableRows["+ j +"].TableColumns["+ k +"].StartRow");
						tableColumn.EndColumn = _ctx.IntegerValue("RecognizeTable.Data.Tables["+ i +"].TableRows["+ j +"].TableColumns["+ k +"].EndColumn");
						tableColumn.EndRow = _ctx.IntegerValue("RecognizeTable.Data.Tables["+ i +"].TableRows["+ j +"].TableColumns["+ k +"].EndRow");
						tableColumn.Height = _ctx.IntegerValue("RecognizeTable.Data.Tables["+ i +"].TableRows["+ j +"].TableColumns["+ k +"].Height");
						tableColumn.Width = _ctx.IntegerValue("RecognizeTable.Data.Tables["+ i +"].TableRows["+ j +"].TableColumns["+ k +"].Width");

						List<string> tableColumn_texts = new List<string>();
						for (int l = 0; l < _ctx.Length("RecognizeTable.Data.Tables["+ i +"].TableRows["+ j +"].TableColumns["+ k +"].Texts.Length"); l++) {
							tableColumn_texts.Add(_ctx.StringValue("RecognizeTable.Data.Tables["+ i +"].TableRows["+ j +"].TableColumns["+ k +"].Texts["+ l +"]"));
						}
						tableColumn.Texts = tableColumn_texts;

						tableRow_tableColumns.Add(tableColumn);
					}
					tableRow.TableColumns = tableRow_tableColumns;

					table_tableRows.Add(tableRow);
				}
				table.TableRows = table_tableRows;

				data_tables.Add(table);
			}
			data.Tables = data_tables;
			recognizeTableResponse.Data = data;
        
			return recognizeTableResponse;
        }
    }
}
