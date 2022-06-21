using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LU_Factorization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Make_Click(object sender, EventArgs e)
        {
            int N = int.Parse(txtBox_Row.Text);
            int M = int.Parse(txtBox_Col.Text);

            dtGridView_Ans.Rows.Clear();
            dtGridView_Ans.Columns.Clear();
            dtGridView_Mtx.Rows.Clear();
            dtGridView_Mtx.Columns.Clear();

            var colA = new DataGridViewColumn();
            colA.HeaderText = " ";
            colA.CellTemplate = new DataGridViewTextBoxCell();
            colA.Width = 40;
            dtGridView_Ans.Columns.Add(colA);
            
            var colA1 = new DataGridViewColumn();
            colA1.HeaderText = "X Answers";
            colA1.CellTemplate = new DataGridViewTextBoxCell();
            colA1.Width = 70;
            dtGridView_Ans.Columns.Add(colA1);

            for (int i = 0; i < M + 1; i++)
            {
                var colMtx1 = new DataGridViewColumn();
                colMtx1.HeaderText = (i == M ? "B" : "X" + (i + 1).ToString());
                colMtx1.CellTemplate = new DataGridViewTextBoxCell();
                colMtx1.Width = 40;
                dtGridView_Mtx.Columns.Add(colMtx1);

                if (i != M)
                {
                    dtGridView_Ans.Rows.Add();
                }
               
            }

            for (int j = 0; j < N; j++)
            {
                dtGridView_Mtx.Rows.Add();
            }
            
            for (int k = 0; k < M; k++)
            {
                dtGridView_Ans[0, k].Value = "X" + (k + 1).ToString();
            }
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            double[,] Mtx_A;
            double[] Mtx_B;
            double[] Answer;
            int N = int.Parse(txtBox_Row.Text);
            int M = int.Parse(txtBox_Col.Text);

            Mtx_A = new double[N, M];
            Mtx_B = new double[N];
            Answer = new double[N];

            for (int i = 0; i < N; i++)
            {
                Mtx_B[i] = Convert.ToDouble(dtGridView_Mtx[N, i].Value);
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Mtx_A[i, j] = Convert.ToDouble(dtGridView_Mtx[j, i].Value);
                }
            }
            //display_Mtx(N, M, Mtx_A, Mtx_B);
            Answer = LU_Factorization(Mtx_A, Mtx_B, M, N);

            for (int i = 0; i < Answer.Length; i++)
            {
                dtGridView_Ans[1, i].Value = Answer[i];
            }           
        }

        private double[] LU_Factorization(double[,] A, double[] B, int m, int w)
        {            
            int n = A.GetLength(0);

            //Forward Elimination
            for (int k = 0; k < n - 1; k++)
            {
                //Pivotting
                int p = k;
                double big = Math.Abs(A[k, k]);
                for (int ii = k + 1; ii < n; ii++)
                {
                    double y = Math.Abs(A[ii, k]);
                    if (y > big)
                    {
                        big = y;
                        p = ii;
                    }
                }
                if (p != k)
                {
                    for (int jj = k; jj < n; jj++)
                    {
                        double u = A[p, jj];
                        A[p, jj] = A[k, jj];
                        A[k, jj] = u;
                    }
                    double o = B[p];
                    B[p] = B[k];
                    B[k] = o;
                }

                for (int i = k + 1; i < n; i++)
                {
                    double factor = A[i, k] / A[k, k];
                    A[i, k] = factor;
                    for (int j = k + 1; j < n; j++)
                    {
                        A[i, j] = A[i, j] - factor * A[k, j];
                    }
                    B[i] = B[i] - factor * B[k];
                }
            }

            //Forward Substitution
            double[] x = new double[n];
            for (int i = 2; i < n; i++)
            {
                double sum = B[i];
                for(int j = 1; j < i-1;i++)
                {
                    sum -= A[i, j] * B[i];
                }
                B[i] = sum;
            }
            //Backward Substitution
            x[n - 1] = B[n - 1] / A[n - 1, n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                double sum = 0;
                for (int j = i + 1; j < n; j++)
                {
                    sum += A[i, j] * x[j];
                }
                x[i] = (B[i] - sum) / A[i, i];  
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    dtGridView_Mtx[m, i].Value = B[i];
                    dtGridView_Mtx[j, i].Value = A[i, j];
                }
            }

            return x;

        }
    }
}
